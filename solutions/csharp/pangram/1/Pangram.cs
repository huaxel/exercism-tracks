public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (!input.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
}
