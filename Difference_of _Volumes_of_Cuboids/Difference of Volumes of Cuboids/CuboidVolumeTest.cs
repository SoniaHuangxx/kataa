using NUnit.Framework;

namespace Difference_of_Volumes_of_Cuboids;

public class Tests
{
    
    [Test]
    public void FindVolumeDifference_Return14()
    {
        var vol = new CuboidVolumes();
        var result = vol.FindVolumeDifference(new int[] {3, 2, 5}, new int[] {1, 4, 4});
        Assert.AreEqual(14, result);
    }
    
    [Test]
    public void FindVolumeDifference_Return106()
    {
        var vol = new CuboidVolumes();
        var result = vol.FindVolumeDifference(new int[] {9, 7, 2}, new int[] {5, 2, 2});
        Assert.AreEqual(106, result);
    }
    
    [Test]
    public void FindVolumeDifference_Return30()
    {
        var vol = new CuboidVolumes();
        var result = vol.FindVolumeDifference(new int[] {11, 2, 5}, new int[] {1, 10, 8});
        Assert.AreEqual(30, result);
    }
    
}