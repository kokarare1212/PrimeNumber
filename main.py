import math
for i in range(2, 10000000):
    k = math.sqrt(i)
    f = True
    for j in range(2, int(k)):
        if (i % j) == 0:
            f = False
    if f:
        print(i)