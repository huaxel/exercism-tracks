public static class Raindrops
{
    public static string Convert(int number)
    {
        var mapping = new Dictionary<int, string>
        {
            { 3, "Pling" },
            { 5, "Plang" },
            { 7, "Plong" }
        };

        var result = string.Concat(mapping
            .Where(kv => number % kv.Key == 0)
            .Select(kv => kv.Value));

        return result.Length > 0 ? result : number.ToString();
    }
}
