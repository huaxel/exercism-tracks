public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var transformedDictionary = new Dictionary<string, int>();
        foreach ((int score, string[] Letters) in old)
        {
            foreach (string letter in Letters)
            {
                transformedDictionary[letter.ToLower()] = score;
            }
        }
    return transformedDictionary;
    }
}