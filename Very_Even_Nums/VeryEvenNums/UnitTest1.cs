using NUnit.Framework;

namespace VeryEvenNums
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void VeryEvenTest1()
        {
            var even = new Kata();
            var sol = even.IsVeryEvenNumber(123);
            Assert.AreEqual(true, sol);
        }
        [Test]
        public void VeryEvenTest2()
        {
            var even = new Kata();
            var sol = even.IsVeryEvenNumber(12);
            Assert.AreEqual(false, sol);
        }
        [Test]
        public void VeryEvenTest3()
        {
            var even = new Kata();
            var sol = even.IsVeryEvenNumber(45);
            Assert.AreEqual(false, sol);
        }
        [Test]
        public void VeryEvenTest4()
        {
            var even = new Kata();
            var sol = even.IsVeryEvenNumber(400000220);
            Assert.AreEqual(true, sol);
        }
    }
}