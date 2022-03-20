namespace Drinkin;
public class NightOut
{
//https://www.codewars.com/kata/5aee86c5783bb432cd000018
    public string Hydrate(string drinkString)
    {
        var totalNoOfDrinks = drinkString.Split(',')
            .Select(x => x.Trim(' ').Substring(0, 1))
            .Sum(x => Convert.ToInt32(x));
        return totalNoOfDrinks==1? String.Format("{0} glass of water", totalNoOfDrinks) : String.Format("{0} glasses of water", totalNoOfDrinks);
    }
}