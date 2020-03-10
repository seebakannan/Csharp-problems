using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i, n, j, tem;
        Console.Write("enter the count: ");
        n = int.Parse(Console.ReadLine());
        int[] arr = new int[100];

        for (i = 0; i < n; i++)
        {
            Console.Write("enter the number {0}: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr[i] < arr[j])
                {
                    tem = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tem;
                }
            }
        }

        for (i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}