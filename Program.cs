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
            try
            {
                Shared.GetAlgoNames();

                int algoNum = int.Parse(Console.ReadLine());

                if (Shared.IsValidAlgorithm(algoNum))
                {
                    Console.WriteLine("\nNumber of elements:");

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
                else
                {
                    Console.WriteLine("\nAlgorithm not implemented");
                    return;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}
