using System;
class MainClass
{
    public static void Main(string[] args)
    {

        int num, i;
        Console.Write("enter the number: ");
        num = int.Parse(Console.ReadLine());
        int count = 0;
        for (i = 1; i <= num; i++)
        {
            count += i;
        }
        double avg = count / num;
        Console.WriteLine("sum of natural numbers: " + count);
        Console.WriteLine("average of the number: " + avg);

    }
}