namespace Difference_of_Volumes_of_Cuboids;

public class CuboidVolumes
{
    public int FindVolumeDifference(int[] a, int[] b)
    {
        return Math.Abs(a.Aggregate((x, y) => x * y) - b.Aggregate((x, y) => x * y));
    }
    
}