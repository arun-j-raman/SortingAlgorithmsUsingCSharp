using System;

namespace SortingAlgorithms
{
    public class Shared
    {
        static int i;
        public static void Swap(int[] myArray, int a, int b)
        {
            if (a == b)
                return;

            int temp = myArray[a];
            myArray[a] = myArray[b];
            myArray[b] = temp;
        }

        public static void PrintArray(int[] myArray)
        {
            for (i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }

        public static void ReadArray(int[] myArray, int n)
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1} : ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }

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
