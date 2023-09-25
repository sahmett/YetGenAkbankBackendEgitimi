

using CalenderApp.Entities;

Console.WriteLine("calender app");

var meeting1 = new Meeting
{
    Title = "Test Meeting",
    Details = new List<string>() { "Katilimci list düzenle", "Bakım yap" },
    StartTime = new DateTime(2023, 09, 18, 20, 00, 00),
    EndTime = new DateTime(2023, 09, 18, 22, 00, 00),
    Guests = new List<string>() { "ali@gmail.com", "veli@gmail.com"}
};

var todo1 = new Todo
{
    Title = "Test Meeting",
    Details = new List<string>() { "Katilimci list düzenle", "Bakım yap" },
    StartTime = new DateTime(2023, 09, 18, 20, 00, 00),
    EndTime = new DateTime(2023, 09, 18, 22, 00, 00),
    Importance = "mühim"
};

meeting1.GetNotification();
todo1.GetNotification();


Console.WriteLine();