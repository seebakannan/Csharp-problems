using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i, j;
        int t;
        int[] num = { 2, 5, 8, 3, 1, 9, -8, -9, -5 };
        for (i = 0; i < num.Length - 2; i++)
        {
            for (j = 0; j < num.Length - 2; j++)
            {
                if (num[j] > num[j + 1])
                {
                    t = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = t;
                }
            }
        }
        foreach (int aa in num)
        {
            Console.WriteLine(aa + " ");
        };


    }
}