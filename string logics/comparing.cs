using System;
class CompareClass
{
    public static void Main(string[] args)
    {

        string str1;
        string str2;
        int i;
        int j;
        Console.Write("enter string 1: ");
        str1 = Console.ReadLine();
        Console.Write("enter string 2: ");
        str2 = Console.ReadLine();

        i = str1.Length;
        j = str2.Length;

        if (str1 == str2 && i == j)
        {
            Console.WriteLine("both are equal and same");

        }
        if (str1 != str2 && i == j)
        {
            Console.WriteLine("both are equal in length but different");

        }
        if (i > j)
        {
            Console.WriteLine("str1 greater than str2");

        }
        if (j > i)
        {
            Console.WriteLine("str2 greater than str1");

        }









    }
}