using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int amount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            amount += birdsPerDay[i];
        }
        return amount;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
                busyDays++;
        }
        return busyDays;
    }
}
