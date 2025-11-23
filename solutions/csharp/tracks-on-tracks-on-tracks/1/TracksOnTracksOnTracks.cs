public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>{"C#", "Clojure", "Elm"};
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        return languages.Append(language).ToList();
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        return languages.AsEnumerable().Reverse().ToList();
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        if (languages[0] == "C#") return true;
        if (languages.Count <=3 && languages[1] == "C#") return true;
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        return languages.Where(l => l != language).ToList();
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Distinct().Count() == languages.Count;
    }
}
