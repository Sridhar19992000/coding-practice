using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 9, 5, 2, 11, 7 };

        int min = numbers[0];   // step 1: assume first number is minimum

        for (int i = 1; i < numbers.Length; i++)   // start from second number
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; // update minimum
            }
        }

        Console.WriteLine("Minimum number in array: " + min);
    }
}
