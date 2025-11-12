using System.Collections.Generic;

public class Anagram
{
    private string baseWord;

    public Anagram(string baseWord)
    {
        this.baseWord = baseWord.ToLower();
    }

    private string orderBaseWord(string word)
    {
        char[] ordered_array = word.ToLower().ToCharArray();
        Array.Sort(ordered_array);
        return new string(ordered_array);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        HashSet<string> anagramsList = new HashSet<string>();

        foreach (string word in potentialMatches)
        {
            if (string.Equals(baseWord, word, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }
            if (orderBaseWord(baseWord) == orderBaseWord(word))
            {
                anagramsList.Add(word);
            }
        }

        return anagramsList.ToArray();
    }
}

