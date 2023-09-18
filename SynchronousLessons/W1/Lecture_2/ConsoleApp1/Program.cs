
using OOPConsoleApp.Entities;
using OOPConsoleApp.Enums;

var student = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Berkcan",
    LastName = "Gümüşışık",
    Gender = Gender.Unknown,
    No = 1,
    RegistrationDate = DateTimeOffset.Now,
    CreatedOn = DateTimeOffset.Now.AddHours(-1),
};

var secondStudent = new Student
{
    Id = Guid.NewGuid(),
    FirstName = "Yakup",
    LastName = "Sıtacı",
    Gender = Gender.Male,
    No = 2,
    RegistrationDate = DateTimeOffset.Now,
    CreatedOn = DateTimeOffset.Now.AddHours(-1),
};
List<Student> students = new List<Student>();
students.Add(student);
students.Add(secondStudent);

students.ForEach(x => Console.WriteLine($"Öğrenci Bilgileri : No - {x.No} {x.FirstName} {x.LastName} {x.Gender}"));

var teacher = new Teacher();
teacher.FirstName = "Berkcan";
teacher.LastName = "Gümüşışık";

Console.WriteLine(teacher.FullName);

teacher.FirstName = "Ahmet";
teacher.LastName = "Kök";

Console.WriteLine(teacher.FullName);
teacher.SayMyName();
teacher.SayMyName();


/**
 *Projeni yapacaksan ya Türkçe ya İngilizce olsun. Ama tavsiye olarak Türkçe yapmanı öneririm.
 *.ForEach() : Bir liste içerisindeki her bir eleman için bir işlem yapmak istiyorsan kullanılır. Tek satırda Linq ile yapılabilir.
 * OOP'de kendini asla tekrar etme ortak alanlar varsa onları grupla. Örneğin; Student ve Teacher classlarında ortak alanlar var. Person classında topladık.
 * Polymorphism : Bir nesnenin birden fazla formu olabilir. Örneğin; Person classı içerisindeki FirstName ve LastName alanları Student ve Teacher classlarında da var. Bu alanlar Person classının bir formudur.
 */


/**
 * Guid Tipi : Eşsiz bir değer oluşturur. Bu sayede aynı değeri oluşturmaz. Özellikle tecrübeli yazılımcılar tarafından kullanılır. ID için int kullanılmaz. Dünyada eşsiz olarak yer alır sadece projede değil.
 * int kullanırsak daha hızlı ve kolay olur. Guid kullanırsak daha yavaş ve zor olur. Ayrıca int daha az yer kaplar. Guid daha fazla yer kaplar.
 * TC, Posta Kodu, Telefon Numarası gibi değerlerde String kullanılır. Çünkü bu değerler ülkeden ülkeye değişir. String kullanırsak daha kolay olur.
 * Student classı içinde ID vereceksek StudentID yerine ID yazılır. Çünkü ID zaten Student classının bir parçasıdır.
 * Enum : Birbirine benzeyen değerleri gruplamak için kullanılır. Örneğin; Cinsiyet, Durum, Renk gibi. Enum kullanacağın yerde String kullanma
 * DateTimeOffset C# ve MSSQL tarafında kullanılır. Farkı : UTC değerini de tutar. Saat farkını da tutar. 
 * Student : PersonBase => Burada Student classı PersonBase classından türetilir. PersonBase classı içerisindeki alanlar burada da kullanılabilir.
*/

/**
- **Proje Dili**: Türkçe veya İngilizce tercih edilmeli. Türkçe önerilir.
- **.ForEach() Kullanımı**: Listelerde her eleman için işlem yapmak için .ForEach() kullanılır, Linq ile tek satırda yapılabilir.
- **OOP İpucu**: Ortak alanları grupla, örneğin Student ve Teacher sınıflarında ortak alanlar varsa Person sınıfında birleştir.
- **Polymorphism**: Bir nesnenin birden fazla formu olabilir. Örneğin, Person sınıfındaki FirstName ve LastName alanları Student ve Teacher sınıflarında da kullanılabilir.
- **Guid Tipi**: Eşsiz değerler oluşturur, tecrübeli yazılımcılar tarafından tercih edilir. ID için int yerine kullanılır. Dünyada eşsiz olur.
- **int vs. Guid**: int hızlı ve az yer kaplar, Guid yavaş ve daha fazla yer kaplar.
- **String Kullanımı**: TC, Posta Kodu, Telefon Numarası gibi ülkeye özgü değerlerde String kullanılmalıdır.
- **ID İsimlendirmesi**: Student sınıfında ID yerine StudentID kullanılmalıdır, çünkü ID zaten sınıfın bir parçasıdır.
- **Enum Kullanımı**: Benzer değerleri gruplamak için Enum kullanılmalıdır, örneğin Cinsiyet, Durum, Renk gibi.
- **DateTimeOffset Kullanımı**: C# ve MSSQL tarafında kullanılır, UTC değerini ve saat farkını tutar.
- **Kalıtım İpucu**: Student sınıfı PersonBase sınıfından türetilir, PersonBase sınıfındaki alanlar burada da kullanılabilir.
 */