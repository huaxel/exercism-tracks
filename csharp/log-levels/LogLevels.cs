static class LogLine
{
    public static string Message(string logLine)
    {
        logLine = logLine[(logLine.IndexOf(']') + 2)..];
        return logLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
