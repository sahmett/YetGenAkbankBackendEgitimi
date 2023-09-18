using Program_2;

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



Console.WriteLine($"Name:{st.FirstName} LastName:{st.LastName} ID: {st.Id}");
Console.WriteLine($"Name:{st2.FirstName} LastName:{st2.LastName} ID: {st2.Id}");
Console.WriteLine($"Name:{st3.FirstName} LastName:{st3.LastName} ID: {st3.Id}");


