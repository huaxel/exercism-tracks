using System.Runtime.InteropServices;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {

        if (string.IsNullOrEmpty(identifier))
        {
            return string.Empty;
        }

        StringBuilder cleanedIdentifier = new();

        bool nextCharToUpper = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                cleanedIdentifier.Append('_');
            }
            else if (char.IsControl(c))
            {
                cleanedIdentifier.Append("CTRL");
            }
            else if (c == '-')
            {
                nextCharToUpper = true;
            }

            else if (char.IsLetter(c) && !(c >= 'α' && c <= 'ω'))
            {
                if (nextCharToUpper)
                {
                    cleanedIdentifier.Append(char.ToUpper(c));
                    nextCharToUpper = false;
                }
                else
                {
                    cleanedIdentifier.Append(c);
                }
            }
        }
    return cleanedIdentifier.ToString();
    }
}