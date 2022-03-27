namespace WeighForWeight;

public class WeightSort
{
    //https://www.codewars.com/kata/55c6126177c9441a570000cc
    internal string WeightSorter(string strng)
    {
        return string.Join(" ", strng.Trim().Split(" ")
            .OrderBy(x => x
                .Select(y => Convert.ToInt32(y.ToString())).Sum())
            .ThenBy(x => x));
    }
}