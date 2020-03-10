using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.Write("enter the number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("enter the number2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("before swap: " + num1 + " " + num2);

        num1 = num1 * num2;
        num2 = num1 / num2;
        num1 = num1 / num2;
        Console.WriteLine("after swap:" + num1 + " " + num2);
    }
}