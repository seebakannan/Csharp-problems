using System;
class MainClass
{
    public static void Main(string[] args)
    {

        int number, n1, n2, n3, i;
        n1 = 0;
        n2 = 1;

        Console.Write("enter the elements: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " ");
        for (i = 2; i < number; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}