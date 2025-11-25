class RemoteControlCar
{
    public int DistanceDriven { get; private set; } = 0;
    public int BatteryPercentage { get; private set; } = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {DistanceDriven} meters";
    }
    public string BatteryDisplay()
    {

        if (BatteryPercentage == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            DistanceDriven += 20;
            BatteryPercentage -= 1;
        }
    }
}
