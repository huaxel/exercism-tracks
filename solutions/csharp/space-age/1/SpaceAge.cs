public class SpaceAge
{
    int seconds;

    public const double EarthYearInSeconds = 31557600;
    public const double MercuryOrbitalPeriod = 0.2408467;
    public const double VenusOrbitalPeriod = 0.61519726;
    public const double MarsOrbitalPeriod = 1.8808158;
    public const double JupiterOrbitalPeriod = 11.862615;
    public const double SaturnOrbitalPeriod = 29.447498;
    public const double UranusOrbitalPeriod = 84.016846;
    public const double NeptuneOrbitalPeriod = 164.79132;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return Math.Round( seconds / EarthYearInSeconds, 8);
    }

    public double OnMercury()
    {
        return Math.Round(OnEarth() / MercuryOrbitalPeriod, 2);
    }

    public double OnVenus()
    {
        return Math.Round(OnEarth() / VenusOrbitalPeriod, 2);
    }

    public double OnMars()
    {
        return Math.Round(OnEarth() / MarsOrbitalPeriod, 2);
    }

    public double OnJupiter()
    {
        return Math.Round(OnEarth() / JupiterOrbitalPeriod, 2);
    }

    public double OnSaturn()
    {
        return Math.Round(OnEarth() / SaturnOrbitalPeriod, 2);
    }

    public double OnUranus()
    {
        return Math.Round(OnEarth() / UranusOrbitalPeriod, 2);
    }

    public double OnNeptune()
    {
        return Math.Round(OnEarth() / NeptuneOrbitalPeriod, 2);
    }
}
