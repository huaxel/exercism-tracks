class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private readonly int speed;
    private readonly int batteryDrain;
    private int metersDriven;
    private int battery;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        metersDriven = 0;
        battery = 100;
    }
    public bool BatteryDrained() => battery < batteryDrain; 
    public int DistanceDriven() => metersDriven;
    public void Drive()
    {
        if (BatteryDrained()) 
            return;
        metersDriven += speed;
        battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
    private readonly int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < distance)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
