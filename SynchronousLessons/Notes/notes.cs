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
 * Entity Base'i veritabanına göndereceğimiz her şeyde kullanırız.
 * Mesela hepsinde Guid kullanmak istemiyorsam verdiğim veri tipine göre değiştirebilirim.
 * class EntityBase<T> şeklinde yazdığımızda T'ye verdiğimiz veri tipine göre değişir.
 * EntityBase de Base temel anlamına gelir
 */