public class Clock : IEquatable<Clock>
{
    private int Hours { get; }
    private int Minutes { get; }

    private const int MinutesInHour = 60;
    private const int HoursInDay = 24;
    private const int MinutesInDay = MinutesInHour * HoursInDay;

    public Clock(int hours, int minutes)
    {

        int totalMinutes = hours * MinutesInHour + minutes;
        totalMinutes = ((totalMinutes % MinutesInDay) + MinutesInDay) % MinutesInDay;
        this.Hours = totalMinutes / MinutesInHour;
        this.Minutes = totalMinutes % MinutesInHour;
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";
    public override bool Equals(object? obj) => Equals(obj as Clock);
    public bool Equals(Clock? other) => other is not null && this.Hours == other.Hours && this.Minutes == other.Minutes;

    public override int GetHashCode() => (Hours, Minutes).GetHashCode();

    public static bool operator ==(Clock? left, Clock? right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null && right is null) return false;
        if (left is null) return false;
        return left.Equals(right);
    } 
    public static bool operator !=(Clock? left, Clock? right) => !(left == right);


}
