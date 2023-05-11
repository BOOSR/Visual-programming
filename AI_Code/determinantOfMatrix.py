def determinant(matrix, mul):

    width = len(matrix)
    if width == 1:
        return mul * matrix[0][0]
    else:
        sign = -1
        answer = 0
        for i in range(width):
            m = []
            for j in range(1, width):
                buff = []
                for k in range(width):
                    if k != i:
                        buff.append(matrix[j][k])
                m.append(buff)
            sign *= -1
            answer = answer + mul * determinant(m, sign * matrix[0][i])
    return answer

test_matrix = [[3,2,-3]
              ,[7,-1,0],
               [2,-4,5]]
#{3[ (-1 * 5) - (0  * -4) ] + 2[ (7 * 5) - (0 * 2) ] + -3[ (7 * -4) - (-1 * 2) ] }
#3(-5) - (2(35) )  + (-3-26) )
#-15-70+78
#-7
print(determinant(test_matrix, 1))