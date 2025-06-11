def istriangle(sides):
    if not all(isinstance(side, (int, float)) and side > 0 for side in sides):
        return False
    a, b, c = sides
    return a + b > c and a + c > b and b + c > a


def equilateral(sides):
    if not istriangle(sides):
        return False
    a, b, c = sides
    return a == b == c


def isosceles(sides):
    if not istriangle(sides):
        return False
    a, b, c = sides
    return a == b or b == c or a == c


#
def scalene(sides):
    if not istriangle(sides):
        return False
    a, b, c = sides
    return a != b and a != c and b != c
