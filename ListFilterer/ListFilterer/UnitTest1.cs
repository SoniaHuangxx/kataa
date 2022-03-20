using NUnit.Framework;

namespace ListFilterer
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetIntsFromList_ShouldPass_2Ints()
        {
            var intList = new ListFilter();
            var list = new List<object>(){1,2,"a","b"};
            var actual = intList.Filter(list);
            var expected = new List<int>(){1,2};
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetIntsFromList_ShouldPass_3Ints()
        {
            var intList = new ListFilter();
            var list = new List<object>(){1,"a","b",0,15};
            var actual = intList.Filter(list);
            var expected = new List<int>(){1,0,15};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetIntsFromList_ShouldPass_4Ints()
        {
            var intList = new ListFilter();
            var list = new List<object>(){1,2,"aasf","1",111,"123",123};
            var actual = intList.Filter(list);
            var expected = new List<int>(){1,2,111,123};
            Assert.AreEqual(expected, actual);
        }

    }
}