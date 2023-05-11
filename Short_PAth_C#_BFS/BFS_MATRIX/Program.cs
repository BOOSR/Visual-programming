using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_MATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] connect = {
            {0, 0, 0, 0, 1, 0},
            {1, 0, 0, 0, 0, 0},
            {0, 1, 0, 0, 0, 0},
            {1, 0, 1, 0, 0, 0},
            {0, 0, 1, 1, 0, 0},
            {1, 1, 1, 0, 1, 0},
            };
            string start = "d";
            string end = "b";
            List<string> path = ShortestPath(connect, start, end);
            Console.Write(string.Join("->", path) + " : Cost ");
            
       

            // محاسبه طول کوتاه‌ترین مسیر با توجه به  Connect
            int cost = 0;
            for (int i = 0; i < path.Count - 1; i++)
            {
                int from = Array.IndexOf(cities, path[i]);
                int to = Array.IndexOf(cities, path[i + 1]);
                cost += connect[from, to];
            }
            Console.WriteLine(cost);
            Console.Read();
        }
 
        static string[] cities = { "a", "b", "c", "d", "e", "f" };

      
        static List<string> ShortestPath(int[,] connect, string start, string end)
        {// ایجاد صف برای ذخیره مسیر‌های قابل پیمودن
            Queue<List<string>> q = new Queue<List<string>>();
            List<string> initPath = new List<string>() { start };
         q.Enqueue(initPath);
     
            while (q.Count > 0)
            {
                List<string> path = q.Dequeue();
                string lastCity = path[path.Count - 1];
              
                if (lastCity == end)
                {
                    return path;
                }
                // بررسی می کنسم گره های همسایه را
                int lastCityIdx = Array.IndexOf(cities, lastCity);
                for (int i = 0; i < cities.Length; i++)
                {
                    if (connect[lastCityIdx, i] == 1 && !path.Contains(cities[i]))
                    {
                        List<string> newPath = new List<string>(path);
                        newPath.Add(cities[i]);
                        q.Enqueue(newPath);
                    }
                }
            }
            
            return null;
        }

    }
}
