using System;

public static class PhoneNumber
{
  public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
  {
    (bool IsNewYork, bool IsFake, string LocalNumber) phoneInfo = (true, false, phoneNumber.Substring(8));
    if (phoneNumber.Substring(0, 3) != "212")
    {
      phoneInfo.IsNewYork = false;
    }
    if (phoneNumber.Substring(4, 3) == "555")
    {
      phoneInfo.IsFake = true;
    }

    return phoneInfo;
  }

  public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
  {
    return phoneNumberInfo.IsFake;
  }
}
