public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    int mask;
    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (mask & (1 << (int)allergen)) != 0;
    }

    public Allergen[] List()
    {
        var allergens = new List<Allergen>();
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                allergens.Add(allergen);
            }
        }
        return allergens.ToArray();
    }
}
