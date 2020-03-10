using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int name, m, i, flag = 0;
        Console.Write("enter the number: ");
        name = int.Parse(Console.ReadLine());
        m = name / 2;
        for (i = 2; i <= m; i++)
        {
            if (name % i == 0)
            {
                Console.Write("the number is not prime");
                flag++;
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("the number is prime");
        }
    }
}