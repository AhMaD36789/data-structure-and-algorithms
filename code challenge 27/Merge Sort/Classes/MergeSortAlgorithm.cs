namespace Merge_Sort.Classes
{
    public class MergeSortAlgorithm
    {
        public void MergeSort(int[] arr)
        {
            int length = arr.Length;

            if (length > 1)
            {
                int mid = (length) / 2;
                int[] left = new int[mid];

                for (int i = 0; i < mid; i++)
                    left[i] = arr[i];

                int[] right = new int[length - mid];

                for (int i = mid; i < length; i++)
                    right[i - mid] = arr[i];

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }

        public void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }

        }
    }
}
