using ProductTransportApp.Entities;
using ProductTransportApp.Services;

Product product1 = new Product("Product 1", 0.5m, 10.99m);
Product product2 = new Product("Product 2", 0.75m, 19.99m);
Product product3 = new Product("Product 3", 1.2m, 29.99m);
Product product4 = new Product("Product 4", 0.3m, 5.49m);

ShippingService sp = new ShippingService();

Console.WriteLine(sp.CalculateTax(product4, "Turkey"));

string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Database\\FileTaxRates.txt";

NotepadServices notepadServices = new();

string[] lines = notepadServices.ReadFromNotepad(path).Split("\r\n");

List<CountryInformation> countryInformations = new();

foreach (var line in lines)
{
    CountryInformation countryInformation = new CountryInformation(line);
    countryInformations.Add(countryInformation);
}

   foreach (var country in countryInformations)
{
   Console.WriteLine( sp.CalculateTax(product4,country));
}


Console.WriteLine("finished");