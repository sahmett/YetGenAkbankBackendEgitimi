
using LibraryMaster.Constants;
using LibraryMaster.Entity;
using LibraryMaster.Service;
using System.IO;

Console.WriteLine("Hello, World!");
string projectFolder = FileLocations.ProjectFolder;

Console.WriteLine(projectFolder);
NotepadService notepadService = new NotepadService();

/*
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory())+"   1!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "   2!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "   4!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "  3!");
*/

/*

// Örnek kullanıcı oluştur
User user = new User
{
    Id = Guid.NewGuid(),
    Name = "John Doe",
    UserDetail = "User details here"
};

// Örnek kitap oluştur
Book book = new Book
{
    Id = Guid.NewGuid(),
    Writer = "Jane Author",
    Title = "Sample Book"
};

// Örnek ödünç alma isteği oluştur
BorrowingRequest borrowingRequest = new BorrowingRequest
{
    Id = Guid.NewGuid(),
    BorrowingBy = "Library User",
    BorrowStartDate = DateTime.Now,
    BorrowEndDate = DateTime.Now.AddDays(14)
};

// Verileri kaydetmek için NotepadService kullan

notepadService.SaveToNotepad(user);
notepadService.SaveToNotepad(book);
notepadService.SaveToNotepad(borrowingRequest);

Console.WriteLine("Veriler başarıyla kaydedildi.");

*/

// Verileri okumak için NotepadService kullan
// Path'leri değişken olarak tanımla
string databaseFolderPath = $"{FileLocations.ProjectFolder}\\Database";
string userFilePath = $"{databaseFolderPath}\\Users.txt";
string bookFilePath = $"{databaseFolderPath}\\Books.txt";
string borrowingRequestFilePath = $"{databaseFolderPath}\\BorrowingRequests.txt";

// Önceki kod buraya gelebilir (veri kaydetme).

// Ardından verileri okumak için NotepadService kullan
string userData = notepadService.GetOnNotepad(userFilePath);
string bookData = notepadService.GetOnNotepad(bookFilePath);
string borrowingRequestData = notepadService.GetOnNotepad(borrowingRequestFilePath);


Console.WriteLine("Kullanıcı Verileri:");
Console.WriteLine(userData);

Console.WriteLine("Kitap Verileri:");
Console.WriteLine(bookData);

Console.WriteLine("Ödünç Alma İsteği Verileri:");
Console.WriteLine(borrowingRequestData);

Console.ReadLine();

string[] lines = bookData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
List<Book> bookList = new List<Book>();
foreach (string line in lines)
{
    string[] parts = line.Split(',');

    if (parts.Length == 2)
    {
        Book book = new Book();
        book.Writer = parts[0].Trim();
        book.Title = parts[1].Trim();
        bookList.Add(book);
    }
}

foreach (Book book in bookList)
{
    Console.WriteLine($"Writer: {book.Writer}");
    Console.WriteLine($"Title: {book.Title}");
    Console.WriteLine(); // Boş satır eklemek için
}
Console.ReadLine();
