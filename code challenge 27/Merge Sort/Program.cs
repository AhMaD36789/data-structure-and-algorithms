using Merge_Sort.Classes;

namespace Merge_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 4, 3, 2, 1 };
            MergeSortAlgorithm algorithm = new MergeSortAlgorithm();
            algorithm.MergeSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}