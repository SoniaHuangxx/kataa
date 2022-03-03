using NUnit.Framework;

namespace Nth_Power_Rules_Them_All;

public class Tests
{
    
    [Test]
    public void ModifiedSum_Return30()
    {
        var nthPow = new NthPow();
        var result = nthPow.ModifiedSum(new int[] {1, 2, 3}, 3);
        Assert.AreEqual(30, result);
    }
    
    [Test]
    public void ModifiedSum_Return270()
    {
        var nthPow = new NthPow();
        var result = nthPow.ModifiedSum(new int[] {1, 2, 3}, 5);
        Assert.AreEqual(270, result);
    }
    
    [Test]
    public void ModifiedSum_Return30_2()
    {
        var nthPow = new NthPow();
        var result = nthPow.ModifiedSum(new int[] {1, 2}, 5);
        Assert.AreEqual(30, result);
    }
}