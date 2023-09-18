using W1._1.OOPConsole.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Student st = new Student()
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
            RAM = "16 GB",
        };

        Computer cmp2 = new Computer("Apple", "Macbook Air", "Intel i5", "8 GB");
        Computer cmp3 = new Computer("Apple", "Macbook Air");

        Console.WriteLine($"Marka: {cmp2.Id} {cmp2.Brand} {cmp2.Model} {cmp2.CPU} {cmp2.RAM} ");
    }
}