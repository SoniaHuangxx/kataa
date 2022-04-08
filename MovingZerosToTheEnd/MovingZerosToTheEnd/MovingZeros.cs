namespace MovingZerosToTheEnd;

public class MovingZeros
{
    internal int[] MoveZerosToEnd(int[] arr)
    {
        //https://www.codewars.com/kata/52597aa56021e91c93000cb0
        var ar = arr.ToList();
        for (int i = 0; i < arr.Length; i++)
        {
            if (ar[i] == 0)
            {
                ar.Remove(ar[i]);
                ar.Add(0);
            }
        }

        return ar.ToArray();
    }
}