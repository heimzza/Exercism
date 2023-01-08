using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = string.Equals(phoneNumber.Substring(0, 3), "212");
        bool isFake = string.Equals(phoneNumber.Substring(4, 3), "555");
        string lastFour = phoneNumber.Substring(phoneNumber.Length - 5);

        return (isNewYork, isFake, lastFour);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
