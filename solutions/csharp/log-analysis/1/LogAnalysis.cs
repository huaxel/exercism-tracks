public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        if (index == -1 || index + delimiter.Length >= str.Length)
        {
            return string.Empty;
        }
        return str.Substring(index + delimiter.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter) 
    {
        int startIntex = str.IndexOf(startDelimiter);
        if (startIntex == -1)
        {
            return string.Empty;
        }
        int endIndex = str.IndexOf(endDelimiter, startIntex + startDelimiter.Length);
        if (endIndex == -1)
        {
            return string.Empty;
        }
        return str.Substring(startIntex + startDelimiter.Length, endIndex - (startIntex + startDelimiter.Length));
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log) 
    {
        return log.SubstringAfter("]: ").Trim();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log) 
    {
        return log.SubstringBetween("[", "]").Trim();
    }
}