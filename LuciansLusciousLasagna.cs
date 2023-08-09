class Lasagna
{
  // TODO: define the 'ExpectedMinutesInOven()' method
  public int ExpectedMinutesInOven()  {
      return 40;
  }
  // TODO: define the 'RemainingMinutesInOven()' method
  public int RemainingMinutesInOven(int actualMins) {
      return ExpectedMinutesInOven() - actualMins;
  }
  // TODO: define the 'PreparationTimeInMinutes()' method
  public int PreparationTimeInMinutes(int numOfLayers) {
      return numOfLayers * 2;
  }
  // TODO: define the 'ElapsedTimeInMinutes()' method
  public int ElapsedTimeInMinutes(int numOfLayers, int minsInOven) {
      return PreparationTimeInMinutes(numOfLayers) + minsInOven;
  }
}
