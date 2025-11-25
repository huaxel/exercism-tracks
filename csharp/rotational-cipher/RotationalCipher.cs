public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char RotateChar(char c)
        {
            if (!char.IsLetter(c)) return c;

            int b = char.IsLower(c) ? 'a' : 'A';

            return (char)(b + (c - b + shiftKey) % 26); 
        }

        var result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            result[i] = RotateChar(text[i]);  
        }
        return new string(result);        
    }
}