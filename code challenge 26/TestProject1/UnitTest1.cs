namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Succeesfully_Sorted()
        {
            int[] arr1 = { 8, 4, 23, 42, 16, 15 };
            InsertionSort.Program.insertionSort(arr1);
            int[] expected = { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(expected, arr1);
        }
    }
}