namespace SortingAlgorithms
{
    public class Sorting
    {
        /// <summary>
        /// Global declaration of Iterating variables
        /// </summary>
        static int i, j;

        /// <summary>
        /// Method to sort an array of integers using Bubble Sort Technique
        /// </summary>
        /// <param name="a">An array of unsorted integers</param>
        /// <param name="n">The length of the unsorted array of integers</param>
        /// <param name="sortOrder">Charater representing the order in which the array should be sorted</param>
        public static void BubbleSort(int[] a, int n, char sortOrder)
        {
            for (i = 0; i < n-1; i++)
            {
                for (j = 0; j < n-1-i; j++)
                {
                    if ((sortOrder.ToString().ToLower() == "a" && a[j] > a[j + 1]) ||
                        (sortOrder.ToString().ToLower() == "d" && a[j] < a[j + 1]))
                        Shared.Swap(a, j, j + 1);
                }
            }
        }

        /// <summary>
        /// Method to sort an array of integers using Selection Sort Technique
        /// </summary>
        /// <param name="a">An array of unsorted integers</param>
        /// <param name="n">The length of the unsorted array of integers</param>
        /// <param name="sortOrder">Charater representing the order in which the array should be sorted</param>
        public static void SelectionSort(int[] a, int n, char sortOrder)
        {
            int min;

            for (int i = 0; i < n - 1; i++)
            {
                min = i;

                for (j = i + 1; j < n; j++)
                {
                    if ((sortOrder.ToString().ToLower() == "a" && a[j] < a[min]) ||
                        (sortOrder.ToString().ToLower() == "d" && a[j] > a[min]))
                        min = j;
                }

                Shared.Swap(a, i, min);
            }
        }
    }

}

