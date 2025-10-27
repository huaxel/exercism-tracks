public static class SquareRoot
{
    public static int Root(int number)
    {
        int rootLow = 0;
        int rootHigh = number;

        if (number < 0)
        {
            throw new System.ArgumentOutOfRangeException(nameof(number), "Cannot compute square root of a negative number.");
        }
        while (rootLow <= rootHigh)
        {
            int mid = (rootLow + rootHigh) / 2;
            int midSquared = mid * mid;

            if (midSquared == number)
            {
                return mid;
            }
            else if (midSquared < number)
            {
                rootLow = mid + 1;
            }
            else
            {
                rootHigh = mid - 1;
            }
        }
    return rootHigh;
    }
}
