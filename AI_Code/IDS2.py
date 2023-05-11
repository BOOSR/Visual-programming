# ما از defaultdict استفاده می کنیم که یک دیکشنری اضافی است که به ما اجازه می دهد تا به سادگی به ارتباطات گراف دسترسی پیدا کنیم.
from collections import defaultdict


class Graph:
	#   تابع سازنده کلاس شامل تعداد رئوس و دیکشنری مربوط به گراف
	def __init__(self, vertices):
		self.V = vertices
		self.graph = defaultdict(list)

	# تابع addEdge برای اضافه کردن یال به گراف
	def addEdge(self, u, v):
		self.graph[u].append(v)
	# - تابع DLS برای جستجوی عمق محدود شده
	def DLS(self, src, target, maxDepth):

		if src == target:
			return True
		if maxDepth <= 0:
			return False
		for i in self.graph[src]:

			if self.DLS(i, target, maxDepth - 1):
				return True
		return False

	def IDDFS(self, src, target, maxDepth):
		for i in range(maxDepth):
			if self.DLS(src, target, i):
				return True
		return False


g = Graph(6)
g.addEdge(0, 1)
g.addEdge(0, 2)
g.addEdge(1, 3)
g.addEdge(1, 4)
g.addEdge(2, 5)
g.addEdge(2, 6)

 #      0          0
 #    /  \
 #   1    2		   1
 #  / \  / \
 # 3  4  5  6	   2

target = 4
maxDepth = 3
src = 0
#  تابع IDDFS برای جستجوی عمق
if g.IDDFS(src, target, maxDepth) == True:
	print("هدف در عمق  یافت می شود!")
else:
	print("هدف در عمق  یافت نمی شود.")
