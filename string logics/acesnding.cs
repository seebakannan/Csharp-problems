using System;
public class Exercise11
{
    public static void Main()
    {
        string str;
        char[] arr1;
        char ch;
        int i, j, k;
        Console.Write("\n\nSort a string array in ascending order :\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        k = str.Length;
        arr1 = str.ToCharArray(0, k);

        for (i = 1; i < k; i++)
            for (j = 0; j < k - i; j++)

                if (arr1[j] > arr1[j + 1])
                {
                    ch = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = ch;
                }
        Console.Write("After sorting the string appears like : \n");
        foreach (char c in arr1)
        {
            ch = c;
            Console.Write("{0} ", ch);
        }
        Console.WriteLine("\n");
    }
}
