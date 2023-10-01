// See https://aka.ms/new-console-template for more information
Console.WriteLine("interfaces implement");
SamsungPrinter samsungPrinter = new SamsungPrinter();
samsungPrinter.PrintPage();

HPPrinter hPPrinter = new HPPrinter();
hPPrinter.PrintPage();


interface IPrinter
{
    void PrintPage();
            
}

class SamsungPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("B&W");
    }
}

class HPPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("Color");
    }
}