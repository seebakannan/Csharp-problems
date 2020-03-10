using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int name, temp, r, sum = 0;
        Console.Write("enter the number: ");
        name = int.Parse(Console.ReadLine());
        temp = name;
        while (name != 0)
        {
            r = name % 10;
            sum = sum + r;
            name = name / 10;
        }
        Console.Write("sum of digits: " + sum);

    }
}