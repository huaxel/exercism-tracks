using System.Runtime.InteropServices;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                identifier = identifier.Replace(c.ToString(), "_");
            }
            else if (char.IsControl(c))
            {
                identifier = identifier.Replace(c.ToString(), "CTRL");
            }
            else if (c == '-')
            {
                int index = identifier.IndexOf(c);
                if (index + 1 < identifier.Length)
                {
                    char nextChar = char.ToUpper(identifier[index + 1]);
                    identifier = identifier.Remove(index, 2).Insert(index, nextChar.ToString());
                }
                else
                {
                    identifier = identifier.Remove(index, 1);
                }
            }
            else if (!char.IsLetter(c))
            {
                identifier = identifier.Replace(c.ToString(), string.Empty);
            }
            else if (c >= 'α' && c <= 'ω')
            {
                identifier = identifier.Replace(c.ToString(), string.Empty);
            }
        }
    return identifier;
    }
}