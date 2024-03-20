using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program
{
    /*
    public void sumAverageElements(int[] arr, int size)
    {
 
        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }
        average = sum / size; 
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    */
    
    static void Main()
    {
        int[] array1 = { 10, -10, -20, 0,15,20,30 };
        Console.WriteLine("Maximum Element : " +array1.Max());
        Console.Read();
    }
}