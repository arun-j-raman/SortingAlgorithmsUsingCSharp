namespace SortingAlgorithms
{
    public class Sorting
    {
        static int i, j;

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

