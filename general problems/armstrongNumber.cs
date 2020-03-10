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
            sum = sum + (r * r * r);
            name = name / 10;
        }
        if (temp == sum)
        {
            Console.Write("Armstrong number");
        }
        else
        {
            Console.Write("Not a Armstrong number");
        }

    }
}