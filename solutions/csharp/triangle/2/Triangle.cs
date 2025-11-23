public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
        => IsTriangle(side1, side2, side3) && Sides(side1, side2, side3).Distinct().Count() == 3;

    public static bool IsIsosceles(double side1, double side2, double side3)
        => IsTriangle(side1, side2, side3) && Sides(side1, side2, side3).Distinct().Count() <= 2;

    public static bool IsEquilateral(double side1, double side2, double side3)
        => IsTriangle(side1, side2, side3) && Sides(side1, side2, side3).Distinct().Count() == 1;

    private static double[] Sides(double side1, double side2, double side3)
        => new[] {side1, side2, side3};

    private static bool IsTriangle (double side1, double side2, double side3){
        var sides = Sides(side1, side2, side3);
        bool biggerThanZero = sides.All(s => s > 0);

        return biggerThanZero && side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2;
    }
}
