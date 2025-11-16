public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement?.Trim() ?? string.Empty;

        bool question = statement.EndsWith("?");
        bool yelling = statement.Any(char.IsLetter) && statement.ToUpper() == statement;
        bool silence = string.IsNullOrWhiteSpace(statement);

        if (silence)
            return "Fine. Be that way!";
        else if (yelling && question)
            return "Calm down, I know what I'm doing!";
        else if (yelling)
            return "Whoa, chill out!";
        else if (question)
            return "Sure.";
        else
            return "Whatever.";
    }
}