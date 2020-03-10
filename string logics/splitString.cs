using System;
public class Exercise3
{
    public static void Main()
    {
        string str;
        int i;
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        Console.Write("The characters of the string are  :  ");

        for (i = 0; i < str.Length; i++)
        {
            Console.Write(" " + str[i]);

        }
        Console.Write("\n\n");
    }
}
