using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string name;
        int i;
        Console.Write("enter the string: ");
        name = Console.ReadLine();
        Console.Write("reversed string is: ");

        for (i = name.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(name[i]);
        }
    }
}