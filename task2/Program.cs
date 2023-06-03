using System;
public class HW_3_task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        char[] charArr = input.ToCharArray();
        int[] int_array = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
        int sum=0;
        for (int i=0;i<int_array.Length;i++)  
        {
            sum=sum+int_array[i];
        }
        Console.WriteLine(sum);
    }
}