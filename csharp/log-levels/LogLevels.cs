using System;
using System.Text.RegularExpressions;
static class LogLine
{
    public static string Message(string logLine)
    {
        return Regex.Replace(logLine, @"^\[\w+\]:\s*", "").Trim();
    }

    public static string LogLevel(string logLine)
    {
        return Regex.Match(logLine, @"\[(\w+)\]").Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
