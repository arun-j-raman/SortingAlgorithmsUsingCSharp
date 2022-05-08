using System;

namespace SortingAlgorithms
{
    class Program
    {
        /// <summary>
        /// Entry point of the console application that accepts user input and displays results
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Sorting Algorithms");

            Console.WriteLine("\nChoose an Algorithm to test by pressing the serial number\n1. Bubble Sort\n2. Selection Sort\n");

            int algoNum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNumber of items:");

            int n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];

            Shared.ReadArray(myArray, n);

            Console.WriteLine("\nSort Order: Press 'A' for ascednding order and 'D' for descending order");

            char sortOrder = (char)Console.Read();

            if (sortOrder.ToString().ToLower() != "a" && sortOrder.ToString().ToLower() != "d")
            {
                Console.WriteLine("\nInvalid sorting order.");
                return;
            }

            Console.WriteLine("\nBefore Sorting");

            Shared.PrintArray(myArray);

            Shared.ChooseAndWork(algoNum, myArray, n, sortOrder);

            Console.WriteLine("\nAfter Sorting");

            Shared.PrintArray(myArray);

        }


    }
}
