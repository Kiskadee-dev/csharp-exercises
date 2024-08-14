using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int battery = 100;

    public int getBattery() => battery;
    public int getSpeed() => speed;
    public int getBatteryDrain() => batteryDrain;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) => (car.getBattery() / car.getBatteryDrain()) * car.getSpeed() >= distance;
}
