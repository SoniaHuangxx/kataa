namespace MergeInterval;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        intervals = intervals.OrderBy(x => x[0]).ToArray();
        List<int[]> result = new List<int[]>() { intervals[0]};
        int index = 0;
        
        for (int i = 1; i < intervals.Length; i++)
        {
            for (int j = 0; j < result.Count; j++)
            {
                if (intervals[i][1] <= result[j][1])
                {
                }
                else if (intervals[i][0] <= result[j][1] && intervals[i][1] > result[j][1])
                {
                    result[j][1] = intervals[i][1];
                    break;
                }
                else if(intervals[i][0] > result[index][1])
                {
                    result.Add(intervals[i]);
                    index++;
                    break;
                }
            }
        }
        return result.ToArray();
    }
}