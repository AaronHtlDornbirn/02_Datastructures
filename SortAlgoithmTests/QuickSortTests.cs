using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class QuickSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuickSortTest_ElementsinRandomOrder_ElementsinCorrectOrder()
        {
            int[] array = new int[] { 10, 30, 50, 20, 40 };

            Quick(array, 0, array.Length - 1);

            Assert.AreEqual(array[0], 10);
            Assert.AreEqual(array[1], 20);
            Assert.AreEqual(array[2], 30);
            Assert.AreEqual(array[3], 40);
            Assert.AreEqual(array[4], 50);
        }

        private static void Quick(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    Quick(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick(array, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}