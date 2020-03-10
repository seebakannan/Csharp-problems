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
            sum = sum * 10 + r;
            name = name / 10;
        }
        Console.Write("the reversed number is: " + sum);

    }
}