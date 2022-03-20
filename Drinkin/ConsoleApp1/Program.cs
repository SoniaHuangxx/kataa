// See https://aka.ms/new-console-template for more information

using System.Linq;

var drinkString = "1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer";
// var drinkStringSplit = drinkString;
var drinkNums = drinkString.Split(',')
    .Select(x => x.Trim(' ').Substring(0, 1))
    .Sum(x => Convert.ToInt32(x));
// var sum = drinkNums.Sum(x => Convert.ToInt32(x));
    // v.Select(x => x.Split(' ').Select(y => int.Parse(y))).ToList();


// foreach (var x in drinkNums)
// {
//     
//     Console.WriteLine(x);
// }
Console.WriteLine(drinkNums);
Console.ReadLine();