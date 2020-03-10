using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int n, i;
        Console.Write("enter the number of numbers: ");
        n = int.Parse(Console.ReadLine());
        int[] arr = new int[100];

        for (i = 0; i < n; i++)
        {
            Console.Write("enter the number {0}: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        for (i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("the maximum number is: " + max);
        Console.WriteLine("the minimum number is: " + min);

    }
}