﻿using W1._1.OOPConsole.Entities;
using W1._1.OOPConsole.Entities.ComputerComponents;
using W1._1.OOPConsole.Enums;
using W1._1.OOPConsole.ValueObjects;

internal class Program
{
    private static void Main(string[] args, W1._1.OOPConsole.Entities.Guest guest1)
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

        Computer cmp4 = new Computer("Apple", "Macbook Air", "Intel i5", RAM, storage);
        Console.WriteLine($"ID: {cmp4.Id} Marka {cmp4.Brand} Model {cmp4.Model} CPU {cmp4.CPU} RAM {cmp4.RAM.Brand} {cmp4.RAM.Capacity.Size}  {cmp4.Storage.Capacity.Size} {cmp4.Storage.Brand} ");

        //W1._1.OOPConsole.Entities.Guest guest1 = new W1._1.OOPConsole.Entities.Guest("Yeliz", "Akın", "12323423432", "0536 666 2266");
        W1._1.OOPConsole.ValueObjects.Guest guest2 = new W1._1.OOPConsole.ValueObjects.Guest("Hakan", "Akın", "12323423432", "0536 666 2266");

        //Reservation reservation = new Reservation(guest1, new DateTime(2025, 10, 1), new DateTime(2025, 10, 5));
        Reservation reservation2 = new Reservation(guest2, new DateTime(2025, 10, 1), new DateTime(2025, 10, 5));

        /*NOTLAR
        Entity nedir?
        Instance nedir?
        Value Object nedir?
        Enum nedir?

        Entity (Varlık): Genellikle bir veritabanı tablosunu veya veri kaynağındaki özgün bir öğeyi temsil eder.
        Instance (Örnek): Bir sınıfın belirli bir örneğini veya veriyi temsil eder.
        Value Object (Değer Nesnesi): Yalnızca değeri taşıyan ve değiştirilemez bir nesnedir, genellikle veri gruplarını temsil eder.
        Enum (Numaralandırma): Sembolik adlarla sabit değerlerin temsil edildiği bir türdür, sınırlı bir küme değerler içerir.

        */

        /* Notlar İki
         
        OOP Yaklaşımı:
        Dil bağımsızdır ve Java, C# gibi dillerde kullanılabilir.
        Amaçları; kodun okunabilirliğini, tekrar kullanılabilirliğini artırmak ve bakım maliyetlerini düşürmektir.

        Instance: 
        Bir sınıftan türetilen nesnedir.

        Property: 
        Bir nesnenin özelliklerini ifade eder.

        Constructor: 
        Nesne oluşturulduğunda çalışan bir metottur.
        Parametre alabilir ve varsayılan constructor'ı eğer biz bir constructor yazarsak siler.
        
        Entity: 
        Veritabanında her bir entity için bir tablo oluşturulur. 
        Entity'lerin özellikleri veritabanındaki sütunlara denk gelir.
        Her bir entity instance, veritabanındaki tabloların bir satırını temsil eder. 
        Her entity, instancelarını eşsiz kılan bir Id gibi bir özelliğe sahip olmalıdır.

        Value Object: Veritabanına tablo olarak yansıtılmazlar. Kod tarafında verileri gruplamak için kullanılırlar. Unique bir Id'leri yoktur.
        */

        /* Sorular Uzun cevap
                Entity Nedir?
        Bir "Entity" (varlık), genellikle bir veritabanı tablosunu veya bir veri kaynağındaki benzersiz bir öğeyi temsil eder.
        Örneğin, bir e-ticaret uygulamasında, bir "Müşteri" veya "Ürün" bir Entity olabilir. 
        Entity Framework gibi ORM (Object-Relational Mapping) araçları, bu Entity'leri C# sınıflarıyla eşleştirir ve 
        veritabanı işlemlerini daha kolay ve nesne odaklı hale getirir.
        
        Instance Nedir?
        Bir "Instance" (örnek), bir sınıfın bir örneğini veya belirli bir veriyi temsil eder. 
        Bir sınıfın tanımı, bir nesne oluşturulduğunda bu nesnenin özelliklerini ve davranışlarını belirtir. 
        Örneğin, bir "Araba" sınıfının bir örneği, belirli bir arabanın rengi, modeli, hızı vb. gibi özelliklerini taşır.
        
        Value Object Nedir?
        "Value Object" (değer nesnesi), sadece değerini taşıyan ve özünde değiştirilemez olan bir nesnedir. 
        Value Object'lar genellikle özellikleri toplu bir şekilde temsil eder ve aynı değere sahip olan
        Value Object'lar eşdeğer kabul edilir. Örneğin, bir tarih aralığı, coğrafi koordinatlar veya para birimi 
        gibi veriler Value Object olarak modellenebilir.
        
        Enum Nedir?
        "Enum" (numaralandırma), sabit değerlerin sembolik adlarla temsil edildiği bir türdür.
        Enum'lar, bir değerin belirli bir sınırlı kümesini temsil etmek için kullanılır.
        Örneğin, haftanın günleri için bir enum kullanabilirsiniz. Bu, kodun daha anlaşılır ve 
        yönetilebilir olmasına yardımcı olabilir.
        */

    }
}