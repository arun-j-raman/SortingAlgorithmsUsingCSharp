using System;
using System.Text.RegularExpressions;

namespace SortingAlgorithms
{
    /// <summary>
    /// Enum of Sorting Algorithm Names
    /// </summary>
    public enum AlgoNames
    {       
        BubbleSort = 1,      
        SelectionSort,       
        InsertionSort
    }
    public class Shared
    {
        /// <summary>
        /// Global declaration variables and constants
        /// </summary>
        static int i;
        const string algoNameRegex = @"(?<!^)(?=[A-Z])";

        /// <summary>
        /// Method to Swap two elements within in an array of integers
        /// </summary>
        /// <param name="myArray">An array containing integers</param>
        /// <param name="a">value to be swapped with b</param>
        /// <param name="b">value to be swapped with a</param>
        public static void Swap(int[] myArray, int a, int b)
        {
            try
            {
                if (a == b)
                    return;

                int temp = myArray[a];
                myArray[a] = myArray[b];
                myArray[b] = temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// Method for printing the elements of an integer array
        /// </summary>
        /// <param name="myArray">An array containing integers</param>
        public static void PrintArray(int[] myArray)
        {
            try
            {
                for (i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]} ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Method for accepting and storing integers into an array
        /// </summary>
        /// <param name="myArray">An array which would hold integers</param>
        /// <param name="n">The length of the array</param>
        public static void ReadArray(int[] myArray, int n)
        {
            try
            {
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter element {i + 1} : ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// Method to check if the serial number of the algorithm is valid or not
        /// </summary>
        /// <param name="userInput">Serial Number of the Algorithm chosen by the user</param>
        /// <returns></returns>
        public static bool IsValidAlgorithm(int userInput)
        {
            try 
            {
                return Enum.IsDefined(typeof(AlgoNames), userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;                
            }

        }

        /// <summary>
        /// Method to get all algorithm names from an enum
        /// </summary>
        public static void GetAlgoNames()
        {
            try
            {
                Console.WriteLine("Sorting Algorithms\n");
                foreach (AlgoNames name in Enum.GetValues(typeof(AlgoNames)))
                {
                    Console.WriteLine($"{((int)name)}. {string.Join(" ", Regex.Split(name.ToString(), algoNameRegex))}");
                }
                Console.WriteLine("\nChoose the serial number of the algorithm for sorting the array\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            try
            {
                switch (serialNumber)
                {
                    case (int)AlgoNames.BubbleSort:
                        Console.WriteLine("\nSorted by Bubble Sort Algorithm\n");
                        Sorting.BubbleSort(myArray, n, sortOrder);
                        break;

                    case (int)AlgoNames.SelectionSort:
                        Console.WriteLine("\nSorted by Selection Sort Algorithm\n");
                        Sorting.SelectionSort(myArray, n, sortOrder);
                        break;

                    case (int)AlgoNames.InsertionSort:
                        Console.WriteLine("\nSorted by Insertion Sort Algorithm\n");
                        Sorting.InsertionSort(myArray, n, sortOrder);
                        break;

                    default:
                        Console.WriteLine("\nNot Implemented\n");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
