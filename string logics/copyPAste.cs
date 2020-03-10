using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string name;
        int i, j;
        Console.Write("enter the string: ");
        name = Console.ReadLine();
        j = name.Length;
        string[] str2 = new string[j];
        for (i = 0; i < j; i++)
        {
            string str1 = name[i].ToString();
            str2[i] = str1;
        }
        Console.WriteLine("the copied word is: " + string.Join("", str2));

        Console.WriteLine("no of char copied: " + j);


    }
}