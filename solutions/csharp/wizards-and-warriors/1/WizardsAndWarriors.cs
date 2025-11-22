abstract class Character
{
    string characterType;
    protected bool isVulnerable;

    protected Character(string characterType)
    {
        this.characterType = characterType;
        this.isVulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        this.isVulnerable = true;
    }

    public bool Prepared { get; private set; } = false;

    public override int DamagePoints(Character target)
    {
        return Prepared ? 12 : 3;
    }

    public void PrepareSpell()
    {
        Prepared = true;
        isVulnerable = false;
    }
}
