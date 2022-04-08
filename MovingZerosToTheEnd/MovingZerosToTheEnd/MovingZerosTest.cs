using NUnit.Framework;

namespace MovingZerosToTheEnd
{
    [TestFixture]
    public class MovingZerosTest
    {
        [Test]
        public void Should_Return1211310000_Given_1201010301()
        {
            var arr = new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};
            var endResult = new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0};
            var movezeros = new MovingZeros();
            var test = movezeros.MoveZerosToEnd(arr);
            Assert.AreEqual(test, endResult);
        }
        
        [Test]
        public void Should_Return_42813100000_Given_42080103010()
        {
            var arr = new int[] {4, 2, 0, 8, 0, 1, 0, 3, 0, 1, 0};
            var endResult = new int[] {4, 2, 8, 1, 3, 1, 0, 0, 0, 0, 0};
            var movezeros = new MovingZeros();
            var test = movezeros.MoveZerosToEnd(arr);
            Assert.AreEqual(test, endResult);
        }

    }
}