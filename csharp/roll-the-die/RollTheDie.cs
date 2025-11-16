public class Player
{
    public int RollDie()
    {
        Random random = new();
        return random.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        Random random = new();
        return random.NextDouble() * 100;
    }
}
