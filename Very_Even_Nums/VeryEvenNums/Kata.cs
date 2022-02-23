namespace VeryEvenNums;
public class Kata
{
    public bool IsVeryEvenNumber(int number)
    {
        var num = CalcIfVeryEven(number);
        return num % 2 == 0;
    }

    private int CalcIfVeryEven(int number)
    {
        if (number <= 9) return number;
        var strArray = number.ToString().ToCharArray();
        var sum = strArray.Sum(c => Int32.Parse(c.ToString()));
        return CalcIfVeryEven(sum);
    }
}