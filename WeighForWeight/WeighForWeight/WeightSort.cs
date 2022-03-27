namespace WeighForWeight;

public class WeightSort
{
    //https://www.codewars.com/kata/55c6126177c9441a570000cc
    internal string WeightSorter(string strng)
    {
        var split = strng.Trim().Split(" ").ToList();

        return string.Join(" ", split
            .OrderBy(s => s
                .Select(x => Convert.ToInt32(x.ToString())).Sum())
            .ThenBy(x => x));
    }
}