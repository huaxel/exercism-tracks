public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var numberList = Enumerable.Range(1, max);
        var sum = numberList.Sum();
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var numberList = Enumerable.Range(1, max);
        return numberList.Select(x => x * x).Sum();
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
