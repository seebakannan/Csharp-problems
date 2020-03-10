using System;

class MainClass
{
    public static void Main(string[] args)
    {

        DateTime currentTime = DateTime.Now;
        string shortDateString = currentTime.ToShortDateString();
        string longDateString = currentTime.ToLongDateString();
        string defaultDateString = currentTime.ToString();
        DateTime tomorrow = currentTime.AddDays(50000);

        Console.WriteLine(shortDateString);
        Console.WriteLine(longDateString);
        Console.WriteLine(defaultDateString);
        Console.WriteLine(tomorrow);
        Console.WriteLine(currentTime);


    }
}
