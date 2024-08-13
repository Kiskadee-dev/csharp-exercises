using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4) {
            return 1;
        }else if (speed >= 5 && speed <= 8) {
            return 0.9;
        }else if (speed == 9) {
            return 0.8;
        }else if (speed == 10) {
            return 0.77;
        }
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rates = SuccessRate(speed);
        double maximum = speed * 221;
        return maximum*rates;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double ratePerHour = ProductionRatePerHour(speed);
        return (int)ratePerHour / 60;
    }
}
