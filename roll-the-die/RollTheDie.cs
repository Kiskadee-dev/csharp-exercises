using System;

public class Player
{
    readonly Random rand = new();

    public int RollDie() => rand.Next(17)+1;

    public double GenerateSpellStrength() => rand.NextDouble()*100d;
}
