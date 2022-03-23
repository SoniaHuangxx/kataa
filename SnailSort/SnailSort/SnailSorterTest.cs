using NUnit.Framework;

namespace SnailSort
{
    [TestFixture]
    public class SnailSorterTest
    {
        [Test]
        public void SnailTest3X3()
        {
            var test = new SnailSorter();
            int[][] input =
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            };
            var result = new int[] {1, 2, 3, 6, 9, 8, 7, 4, 5};
            Assert.AreEqual(result , test.SortSnailer(input));
        }
        
        [Test]
        public void SnailTest4X4()
        {
            var test = new SnailSorter();
            int[][] input =
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 7, 8},
                new[] {9, 10, 11, 12},
                new[] {13, 14, 15, 16},
            };
            var result = new int[] {1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10};
            Assert.AreEqual(result , test.SortSnailer(input));
        }
        
        [Test]
        public void SnailTest5X5()
        {
            var test = new SnailSorter();
            int[][] input =
            {
                new[] {1, 2, 3, 4, 1},
                new[] {5, 6, 7, 8, 2},
                new[] {9, 10, 11, 12, 3},
                new[] {13, 14, 15, 16, 4},
                new[] {13, 14, 15, 16, 4},
            };
            var result = new int[] {1,2,3,4,1,2,3,4,4,16,15,14,13,13,9,5,6,7,8,12,16,15,14,10,11};
            Assert.AreEqual(result , test.SortSnailer(input));
        }
    }
}