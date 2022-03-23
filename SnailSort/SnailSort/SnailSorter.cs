namespace SnailSort;

public class SnailSorter
{
    //Question https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/train/csharp
    public int[] SortSnailer(int[][] array)
    {
        var n = array.Length;
        var result = new int[n * n];
        var index = n;
        var x = 0;
        var y = n - 1;
        var direction = 1;
        var maxMoves = n - 1;
        
        for (var i = 0; i < n; i++)
        {
            result[i] = array[0][i];
        }

        while (index < n * n)
        {
            for (var i = 0; i < maxMoves; i++)
            {
                x = direction > 0 ? x += 1 : x -= 1;
                result[index] = array[x][y];
                index++;
            }

            direction *= -1;
                
            for (var i = 0; i < maxMoves; i++)
            {
                y = direction > 0 ? y += 1 : y -= 1;
                result[index] = array[x][y];
                index++;
            }

            maxMoves--;
        }
        
        return result;
    }
    
    
}