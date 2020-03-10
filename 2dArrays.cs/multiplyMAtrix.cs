using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i, j, k, tem = 0;
        int r1, r2, c1, c2;
        Console.WriteLine("input the number of rows and coloums of first matrix: ");
        Console.Write("rows: ");
        r1 = int.Parse(Console.ReadLine());
        Console.Write("coloums: ");
        c1 = int.Parse(Console.ReadLine());
        Console.WriteLine("input the number of rows and coloums of second matrix: ");
        Console.Write("rows: ");
        r2 = int.Parse(Console.ReadLine());
        Console.Write("coloums: ");
        c2 = int.Parse(Console.ReadLine());

        int[,] mat1 = new int[50, 50];
        int[,] mat2 = new int[50, 50];
        int[,] sum = new int[50, 50];
        if (c1 != r2)
        {
            Console.WriteLine("multiplication is not possible");
        }
        else
        {
            Console.WriteLine("input elements in the first matrix:");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0},[{1}]] :", i, j);
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("input elements in the second matrix:");

            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0},[{1}]] :", i, j);
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("first matrix:\n");
            for (i = 0; i < r1; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c1; j++)
                {
                    Console.Write("{0}\t ", mat1[i, j]);
                }
            }

            Console.Write("second matrix:\n");
            for (i = 0; i < r2; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t ", mat2[i, j]);
                }
            }

            for (i = 0; i < r1; i++)
                for (j = 0; j < c1; j++)
                    sum[i, j] = 0;
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    tem = 0;
                    for (k = 0; k < c1; k++)
                    {
                        tem = tem + mat1[i, k] * mat2[k, j];
                        sum[i, j] = tem;
                    }
                }
            }

            Console.Write("\nThe multiplication of two matrix is : \n");
            for (i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t", sum[i, j]);
                }
            }

        }
    }
}