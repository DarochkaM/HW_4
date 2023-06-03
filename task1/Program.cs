using System;
public class HW_3_task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int B = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Math.Pow(A,B));
    }
}