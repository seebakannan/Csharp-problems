using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string num;
        char[] ch;
        int i, j;
        char t;

        num = Console.ReadLine("enter the string: ");
        ch = num.ToCharArray();

        for (i = 0; i < num.Length - 2; i++)
        {
            for (j = 0; j < ch.Length - 1; j++)
            {
                if (ch[j] > ch[j + 1])
                {
                    t = ch[j];
                    ch[j] = ch[j + 1];
                    ch[j + 1] = t;
                }
            }
        }
        Console.WriteLine(ch);
    }
}