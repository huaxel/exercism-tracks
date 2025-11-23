public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        // var digits = number.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        var digits = (from c in number.ToString()
                      select c - '0')
                    .ToArray();

        var power = digits.Length;
        // var sum = digits.Select(d => (int)Math.Pow(d, power)).Sum();
        var sum = (from d in digits
                   select (int)Math.Pow(d, power))
                  .Sum();
        return sum == number;
    }
}
