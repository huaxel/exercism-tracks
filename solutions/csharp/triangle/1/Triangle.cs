public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        double[] sides = {side1, side2, side3};
        bool allDiff = sides.Distinct().Count() == 3;
        return IsTriangle(side1, side2, side3) && allDiff;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        double[] sides = {side1, side2, side3};
        bool twoEqual = sides.Distinct().Count() <= 2;
        return IsTriangle(side1, side2, side3) && twoEqual;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        double[] sides = {side1, side2, side3};
        bool allEqual = sides.Distinct().Count() == 1;
        return IsTriangle(side1, side2, side3) && allEqual;
    }

    public static bool IsTriangle (double side1, double side2, double side3){
        double[] sides = {side1, side2, side3};
        bool biggerThanZero = sides.All(s => s > 0);

        return biggerThanZero && side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
    }
}
