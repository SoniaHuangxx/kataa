using NUnit.Framework;

namespace WeighForWeight
{
    [TestFixture]
    public class SnailSorterTest
    {
        [Test]
        public void SortTests()
        {
            var test = new WeightSort();
            
            string input1 = "103 123 4444 99 2000";
            string result1 = "2000 103 123 4444 99";

            string input2 = "2000 10003 1234000 44444444 9999 11 11 22 123";
            string result2 = "11 11 2000 10003 22 123 1234000 44444444 9999";
            Assert.AreEqual(result1 , test.WeightSorter(input1));
            Assert.AreEqual(result2 , test.WeightSorter(input2));
        }

    }
}