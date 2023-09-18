using W1._1.OOPConsole.Entities;
using W1._1.OOPConsole.Entities.ComputerComponents;
using W1._1.OOPConsole.Enums;
using W1._1.OOPConsole.ValueObjects;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Student st = new Student()
        {
            Id = 1,
            FirstName = "Osman",
            LastName = "Kazancı",
        };

        Student st2 = new Student()
        {
            Id = 2,
            FirstName = "Aygun",
            LastName = "Bayram",
        };

        Student st3 = new Student(12, "Murat", "Sultan");
        */

        /*
        Console.WriteLine($"Name:{st.FirstName} LastName:{st.LastName} ID: {st.Id}");
        Console.WriteLine($"Name:{st2.FirstName} LastName:{st2.LastName} ID: {st2.Id}");
        Console.WriteLine($"Name:{st3.FirstName} LastName:{st3.LastName} ID: {st3.Id}");
        */

        Computer cmp1 = new Computer()
        {
            Brand = "Apple",
            Model = "Macbook Pro",
            CPU = "Intel i7",
            //RAM = "16 GB",
        };

        // Computer cmp2 = new Computer("Apple", "Macbook Air", "Intel i5", "8 GB");
        Computer cmp3 = new Computer("Apple", "Macbook Air");
        // Computer cmp4 = new Computer("Apple", "Macbook Air", "Intel i5", "8 GB", "WD Blue", 1, CapacitySizeType.MB);


        //Storage storage = new Storage("WD Blue", 1, CapacitySizeType.MB);
        Storage storage = new Storage("WD Blue", new Capacity(1, CapacitySizeType.MB));

        RAM RAM = new RAM("WD Blue", new Capacity(1, CapacitySizeType.MB));

        Computer cmp4 = new Computer("Apple", "Macbook Air", "Intel i5", RAM,storage);
        Console.WriteLine($"ID: {cmp4.Id} Marka {cmp4.Brand} Model {cmp4.Model} CPU {cmp4.CPU} RAM {cmp4.RAM.Brand} {cmp4.RAM.Capacity.Size}  {cmp4.Storage.Capacity.Size} {cmp4.Storage.Brand} ");

        /*
        NOTLAR
        Entity nedir?
        Value Object nedir?
        Enum nedir?
        */



    }
}