using System;
using System.Text.RegularExpressions;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var regexPattern = @"(?:^|[\s\-_`])([A-Za-z])";
        var matches = Regex.Matches(phrase, regexPattern);
        var acronym = string.Concat(matches.Select(m => m.Groups[1].Value)).ToUpper();
        return acronym;
    }
}