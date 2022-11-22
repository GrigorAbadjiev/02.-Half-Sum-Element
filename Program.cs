using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int readCount = int.Parse(Console.ReadLine());
            int sum = 0, maxNumber = int.MinValue;

            for (int i = 0; i < readCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if (sumWithoutMaxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int difference = Math.Abs(sumWithoutMaxNumber - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }

    }
}
