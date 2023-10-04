
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
    Book book = new Book(); // Her satır için yeni bir Book nesnesi oluşturun
    book.SetValues(line); // SetValues metodu ile kitap verilerini doldurun
    bookList.Add(book); // Book nesnesini listeye ekleyin
}

foreach (Book book in bookList)
{
    Console.WriteLine($"Writer: {book.Writer}");
    Console.WriteLine($"Title: {book.Title}");
    Console.WriteLine(); // Boş satır eklemek için
}
Console.ReadLine();


/*
 * PROMPT:string[] lines = bookData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
 * kodun nasıl çalıştığını örnekle anlat basitçe.

Tabii ki! İşte `string[] lines = bookData.Split('\n', StringSplitOptions.RemoveEmptyEntries);` kodunun nasıl çalıştığını
basitbir örnek ile anlatayım.

Örneğin, aşağıdaki `bookData` değişkeni içinde kitap bilgilerini içeren bir metin olduğunu düşünelim:

```csharp
string bookData = "Jane Author,Sample Book\nAuthor A,Book 1\nAuthor B,Book 2\n\nAuthor C,Book 3\n";
```

Bu metin, satır başlarına göre kitap bilgilerini içerir ve bazı satırlarda boş satırlar da vardır. Şimdi bu metni `'\n'` 
(yeni satır) karakteri ile ayıralım:

```csharp
string[] lines = bookData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
```

Bu kod satırı, `bookData` metnini `'\n'` karakterine göre böler ve her yeni satırda bir dize öğesi oluşturur. `
StringSplitOptions.RemoveEmptyEntries` seçeneği kullanıldığı için boş satırlar (`\n\n`) metinden çıkarılır.

Örnek olarak, `lines` dizisi şu şekilde doldurulur:

```csharp
lines[0] = "Jane Author,Sample Book"
lines[1] = "Author A,Book 1"
lines[2] = "Author B,Book 2"
lines[3] = "Author C,Book 3"
```

Görüldüğü gibi, bu kod, her bir satırı ayrı bir dize öğesi olarak `lines` dizisine yerleştirir ve boş satırları
(`\n\n`) dikkate almaz. Bu, metinden veri çıkartırken ve verileri işlerken kullanışlı bir tekniktir.
 */