using System;

public static class PhoneNumber
{
    const string NewYork = "212"; 
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = phoneNumber[0..3] == NewYork;
        bool IsFake = phoneNumber[4..7] == "555";
        string LocalNumber = phoneNumber[8..12];
        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
