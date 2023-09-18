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



Console.WriteLine($"Name:{st.FirstName} LastName:{st.LastName} ID: {st.Id}");
Console.WriteLine($"Name:{st2.FirstName} LastName:{st2.LastName} ID: {st2.Id}");


