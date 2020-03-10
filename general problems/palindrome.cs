using System;
class MainClass
{
    public static void Main(string[] args)
    {

        string name;
        Console.Write("enter the string: ");
        name = Console.ReadLine();
        string rev = "";

        for (int i = name.Length - 1; i >= 0; i--)
        {
            rev += name[i].ToString();
        }
        if (rev == name)
        {
            Console.Write("palindrome");
        }
        else
        {
            Console.Write("not palindrome");
        }
    }
}