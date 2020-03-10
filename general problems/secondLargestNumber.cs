using System;
class MainClass
{
    public static void Main(string[] args)
    {

        int[] arr = { 23, 112, 43, 43, 55, 66, 100, 888 };
        int max1, max2, i;
        max1 = max2 = arr[0];

        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if (arr[i] > max2)
            {
                max2 = arr[i];
            }
        }
        Console.Write("the largest number is: " + max1 + "\n");

        Console.Write("the second largest number is: " + max2);
    }
}