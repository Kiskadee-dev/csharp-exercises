using System;

class RemoteControlCar
{
    private int DistanceDriven;
    private int Battery = 100;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {DistanceDriven} meters";

    public string BatteryDisplay() => Battery > 0 ? $"Battery at {Battery}%" : $"Battery empty";

    public void Drive()
    {
        if (Battery == 0)
            return;
        DistanceDriven += 20;
        Battery -= 1;
    }
}
