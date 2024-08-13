class Lasagna
{
    const int LasagnaTime = 40; //minutes
    public int ExpectedMinutesInOven()
    {
        return LasagnaTime;
    }

    public int RemainingMinutesInOven(int CookedMinutes)
    {
        return ExpectedMinutesInOven() - CookedMinutes;
    }

    public int PreparationTimeInMinutes(int Layers)
    {
        return Layers * 2;
    }

    public int ElapsedTimeInMinutes(int Layers, int CookedMinutes)
    {
        return PreparationTimeInMinutes(Layers) + CookedMinutes;
    }
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
