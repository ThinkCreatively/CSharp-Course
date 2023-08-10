using System;

static class AssemblyLine
{
  public static double SuccessRate(int speed)
  {
    if (speed == 0)
    {
      return 0;
    }
    if (speed > 0 && speed < 5)
    {
      return 1;
    }
    if (speed > 4 && speed < 9)
    {
      return 0.9;
    }
    if (speed == 9)
    {
      return 0.8;
    }

    return 0.77;
  }

  public static double ProductionRatePerHour(int speed)
  {
    int ratePerHour = 221;
    return (speed * ratePerHour) * SuccessRate(speed);
  }

  public static int WorkingItemsPerMinute(int speed)
  {
    return (int)ProductionRatePerHour(speed) / 60;
  }
}
