public static class ScrabbleScore
{
    public static readonly Dictionary<string, int> ScoreTable = new()
    {
        ["AEIOULNRST"] = 1,
        ["DG"] = 2,
        ["BCMP"] = 3,
        ["FHVWY"] = 4,
        ["K"] = 5,
        ["JX"] = 8,
        ["QZ"] = 10
    };

    public static int Score(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;
        input = input.ToUpperInvariant();
        return input
        .Select(c => ScoreTable.First(kv => kv.Key.Contains(c)).Value)
        .Sum();
    }
}
