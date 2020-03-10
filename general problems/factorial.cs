using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int name;
        int i, fact = 1;
        Console.Write("enter the number: ");
        name = int.Parse(Console.ReadLine());
        for (i = 1; i <= name; i++)
        {
            fact *= i;
        }
        Console.Write(fact);
    }
}