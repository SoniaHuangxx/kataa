namespace Nth_Power_Rules_Them_All;

public class NthPow
{
    public int ModifiedSum(int[] a, int n)
    {
        var sum = 0.0;
        foreach (var t in a)
        {
            sum += Math.Pow(t, n) - t;
        }
        return (int)sum;
    }
}