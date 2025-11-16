using System;
using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        StringBuilder encoded = new ();
        int count = 1;
        for (int i = 1; i <= input.Length; i++)
        {
            if (i < input.Length && input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    encoded.Append(count);
                }
                encoded.Append(input[i - 1]);
                count = 1;

            }
        }
        return encoded.ToString();
    }
    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        StringBuilder decoded = new ();
        int number = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsDigit(c))
            {
                number = number * 10 + (c - '0');
            }
            else
            {
                int count = number == 0 ? 1 : number;
                for (int j = 0; j < count; j++)
                {
                    decoded.Append(c);
                }
                number = 0;
            }
        }
        return decoded.ToString();
    }
}
