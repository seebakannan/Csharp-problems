using System;
class CountClass
{
    public static void Main(string[] args)
    {

        string name;
        int i;
        int j = 0;
        int k = 0;
        int l = 0;
        Console.Write("enter the string: ");
        name = Console.ReadLine();

        for (i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
            {
                j++;
            }

            else if (name[i] >= '0' && name[i] <= '9')
            {
                k++;
            }
            else
            {
                l++;
            }
        }
        Console.WriteLine("alphabets= " + j);
        Console.WriteLine("numbers= " + k);
        Console.WriteLine("speacial characters= " + l);
    }
}