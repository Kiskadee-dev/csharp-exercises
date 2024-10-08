using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213F;
        }
        else if (balance < 1000)
        {
            return 0.5F;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 1.621F;
        }
        else
        {
            return 2.475F;
        }
    }

    public static decimal Interest(decimal balance) => balance * (decimal)(InterestRate(balance) / 100F);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        while (balance <= targetBalance)
        {
            year++;
            balance += Interest(balance);
        }
        return year;
    }
}
