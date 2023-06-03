using System;
public class HW_4_task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter array of length 8");

        int[] A = new int[8];
        for (int i=0;i<A.Length;i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("[{0}]", string.Join(", ", A));
    }
}