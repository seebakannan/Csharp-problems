using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string word;
        int i;
        int count = 1;
        Console.Write("enter the string: ");
        word = Console.ReadLine();
        for (i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ' || word[i] == '\n')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}