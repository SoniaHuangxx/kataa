namespace ListFilterer;
public class ListFilter
{
//https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
    public IEnumerable<int> Filter(List<object> listOfItems)
    {
        return listOfItems.Where(x => x.GetType() == typeof(int)).Select(x => Convert.ToInt32(x));
    }
}