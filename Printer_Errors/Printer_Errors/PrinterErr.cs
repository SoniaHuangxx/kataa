namespace Printer_Errors;

public class PrinterErr
{
    public string CheckForPrintErrors(string input)
    {
        var printErrs = input.ToCharArray().Count(x => (int) x > 109);
        return $"{printErrs}/{input.Length}";
    }
}