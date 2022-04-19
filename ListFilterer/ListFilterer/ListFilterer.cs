namespace ListFilterer;
public class ListFilter
{
//https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
    public IEnumerable<int> Filter(List<object> listOfItems)
    {
        return listOfItems.Where(x => x is int).Select(Convert.ToInt32);
    }
}