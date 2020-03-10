using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i, j, n;
        int[,] arr1 = new int[50, 50];
        int[,] arr2 = new int[50, 50];
        int[,] sum = new int[50, 50];

        Console.Write("input the size of the square matrix(less than 5): ");

        n = int.Parse(Console.ReadLine());
        // second matrix;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("input elements in the first matrix {0},{1} : ", i, j);

                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //first matrix
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("input elements in the second matrix {0},{1} : ", i, j);

                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //sum of matrix;

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                sum[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        //print the addition of matrix;
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}\t", sum[i, j]);
            }
        }
    }
}