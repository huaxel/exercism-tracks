public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char RotateChar(char c)
        {
            if (char.IsLower(c))
            {
                return (char)('a' + (c - 'a' + shiftKey) % 26);
            }
            else if (char.IsUpper(c))
            {
                return (char)('A' + (c - 'A' + shiftKey) % 26);
            }
            else
            {
                return c;
            }

        }
        var result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            result[i] = RotateChar(text[i]);  
        }
        return new string(result);        
    }
}