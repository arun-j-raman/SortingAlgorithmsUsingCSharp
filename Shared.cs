using System;

namespace SortingAlgorithms
{
    public class Shared
    {
        /// <summary>
        /// Global declaration of iteration variable
        /// </summary>
        static int i;

        /// <summary>
        /// Method to Swap two elements within in an array of integers
        /// </summary>
        /// <param name="myArray">An array containing integers</param>
        /// <param name="a">value to be swapped with b</param>
        /// <param name="b">value to be swapped with a</param>
        public static void Swap(int[] myArray, int a, int b)
        {
            if (a == b)
                return;

            int temp = myArray[a];
            myArray[a] = myArray[b];
            myArray[b] = temp;
        }

        /// <summary>
        /// Method for printing the elements of an integer array
        /// </summary>
        /// <param name="myArray">An array containing integers</param>
        public static void PrintArray(int[] myArray)
        {
            for (i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method for accepting and storing integers into an array
        /// </summary>
        /// <param name="myArray">An array which would hold integers</param>
        /// <param name="n">The length of the array</param>
        public static void ReadArray(int[] myArray, int n)
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1} : ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Method for choosing a suitable sorting algorithm for sorting an array of integers
        /// </summary>
        /// <param name="serialNumber">Number representing the algorithm to be used for sorting</param>
        /// <param name="myArray">An array of integers that needs to be sorted</param>
        /// <param name="n">The length of the integer array</param>
        /// <param name="sortOrder">Character representing the order in which the array has to be sorted</param>
        public static void ChooseAndWork(int serialNumber, int[] myArray, int n, char sortOrder)
        {
            switch (serialNumber)
            {
                case 1:
                    Console.WriteLine("\nSorted by Bubble Sort Algorithm\n");
                    Sorting.BubbleSort(myArray, n, sortOrder);
                    break;

                case 2:
                    Console.WriteLine("\nSorted by Selection Sort Algorithm\n");
                    Sorting.SelectionSort(myArray, n, sortOrder);
                    break;
            }
        }

    }
}
