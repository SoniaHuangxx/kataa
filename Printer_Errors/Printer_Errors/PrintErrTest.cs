using NUnit.Framework;

namespace Printer_Errors;

public class Tests
{
    
    [Test]
    public void Test1()
    {
        var printer = new PrinterErr();
        var result = printer.CheckForPrintErrors("aaaxbbbbyyhwawiwjjjwwm");
        Assert.AreEqual("8/22", result);
    }
    [Test]
    public void Test2()
    {
        var printer = new PrinterErr();
        var result = printer.CheckForPrintErrors("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz");
        Assert.AreEqual("3/56", result);
    }
    [Test]
    public void Test3()
    {
        var printer = new PrinterErr();
        var result = printer.CheckForPrintErrors("aaabbbbhaijjjm");
        Assert.AreEqual("0/14", result);
    }
    [Test]
    public void Test4()
    {
        var printer = new PrinterErr();
        var result = printer.CheckForPrintErrors("aaaxbbbbyyhwawiwjjjwwmnnnopqrs");
        Assert.AreEqual("16/30", result);
    }
}