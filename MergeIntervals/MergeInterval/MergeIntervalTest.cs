using ExpectedObjects;
using NUnit.Framework;

namespace MergeInterval
{
    [TestFixture]
    public class MergeIntervalTest
    {
        [Test]
        public void MergeIntervals_Test1()
        {
            var merger = new MergeIntervals();
            var intervals = new[]
            {
                new[]{1,3}, new[]{2,6}, new[]{8,10},new[]{15,18}
            };
            var actual = merger.Merge(intervals);
            var expected = new[]
            {
                new[]{1,6}, new[]{8,10}, new[]{15,18}
            };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
        
        [Test]
        public void MergeIntervals_Test2()
        {
            var merger = new MergeIntervals();
            var intervals = new[]
            {
                new[]{1,3}, new[]{2,2}, new[]{2,2},new[]{2,3},new[]{5,7},new[]{4,6},new[]{3,3}
            };
            var actual = merger.Merge(intervals);
            var expected = new[]
            {
                new[]{1,3}, new[]{4,7}
            };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
        
    }
}