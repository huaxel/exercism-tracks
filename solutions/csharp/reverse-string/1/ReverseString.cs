public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input == null) return string.Empty;
        char[] charArray = input.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }
}