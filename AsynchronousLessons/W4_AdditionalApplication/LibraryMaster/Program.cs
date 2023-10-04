
using LibraryMaster.Constants;
using LibraryMaster.Entity;
using LibraryMaster.Service;

Console.WriteLine("Hello, World!");
string projectFolder = FileLocations.ProjectFolder;

Console.WriteLine(projectFolder);

/*
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory())+"   1!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "   2!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "   4!");
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "  3!");
*/

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
NotepadService notepadService = new NotepadService();
notepadService.SaveToNotepad(user);
notepadService.SaveToNotepad(book);
notepadService.SaveToNotepad(borrowingRequest);

Console.WriteLine("Veriler başarıyla kaydedildi.");

// Verileri okumak için NotepadService kullan
string userData = notepadService.GetOnNotepad($"{FileLocations.ProjectFolder}\\Database\\Users.txt");
string bookData = notepadService.GetOnNotepad($"{FileLocations.ProjectFolder}\\Database\\Books.txt");
string borrowingRequestData = notepadService.GetOnNotepad($"{FileLocations.ProjectFolder}\\Database\\BorrowingRequests.txt");

Console.WriteLine("Kullanıcı Verileri:");
Console.WriteLine(userData);

Console.WriteLine("Kitap Verileri:");
Console.WriteLine(bookData);

Console.WriteLine("Ödünç Alma İsteği Verileri:");
Console.WriteLine(borrowingRequestData);

Console.ReadLine();


List<User> users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    UserDetail = "User 1 details here"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    UserDetail = "User 2 details here"
                }
            };

// Örnek kitaplar oluştur
List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = Guid.NewGuid(),
                    Writer = "Author A",
                    Title = "Book 1"
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Writer = "Author B",
                    Title = "Book 2"
                }
            };

// Örnek ödünç alma istekleri oluştur
List<BorrowingRequest> borrowingRequests = new List<BorrowingRequest>
            {
                new BorrowingRequest
                {
                    Id = Guid.NewGuid(),
                    BorrowingBy = "User 1",
                    BorrowStartDate = DateTime.Now,
                    BorrowEndDate = DateTime.Now.AddDays(14)
                },
                new BorrowingRequest
                {
                    Id = Guid.NewGuid(),
                    BorrowingBy = "User 2",
                    BorrowStartDate = DateTime.Now,
                    BorrowEndDate = DateTime.Now.AddDays(7)
                }
            };

// Verileri kaydetmek için NotepadService kullan

foreach (var user2 in users)
{
    notepadService.SaveToNotepad(user2);
}

foreach (var book2 in books)
{
    notepadService.SaveToNotepad(book2);
}

foreach (var request in borrowingRequests)
{
    notepadService.SaveToNotepad(request);
}

Console.WriteLine("Veriler başarıyla kaydedildi.");

Console.WriteLine("Kullanıcı Verileri:");
Console.WriteLine(userData);

Console.WriteLine("Kitap Verileri:");
Console.WriteLine(bookData);

Console.WriteLine("Ödünç Alma İsteği Verileri:");
Console.WriteLine(borrowingRequestData);

Console.ReadLine();



