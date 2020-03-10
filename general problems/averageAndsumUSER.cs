using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int num, i;
        int count = 0;
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine("enter the number-{0}: ", i);
            num = int.Parse(Console.ReadLine());
            count += num;
        }
        Console.WriteLine("total count = " + count);
        double avg = count / 10;
        Console.WriteLine("äverage= " + avg);
    }
}