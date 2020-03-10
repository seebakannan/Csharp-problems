using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i, j;
        int[,] arr = new int[3, 3];

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write("input element in the matrix {0},{1}: ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (i = 0; i < 3; i++)
        {
            Console.Write("\n");
            for (j = 0; j < 3; j++)
                Console.Write("{0}\t", arr[i, j]);
        }
    }
}