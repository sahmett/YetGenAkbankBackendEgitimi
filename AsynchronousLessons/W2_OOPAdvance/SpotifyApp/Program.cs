
using SpotifyApp.Entities;

#region OOP Part
/*
Accont a1 = new Accont("ali", "veli");

//a1.paymentSys(13433);
a1.Balance -= 400;
a1.Balance -= 450;
a1.Balance -= 600;
*/
#endregion

Song song1 = new Song("Bohemian Rhapsody", "Queen", "Roy Thomas Baker", "Freddie Mercury");
Song song2 = new Song("Imagine", "John Lennon", "John Lennon, Yoko Ono, Phil Spector", "John Lennon");
Song song3 = new Song("Hotel California", "Eagles", "Bill Szymczyk", "Don Felder, Don Henley, Glenn Frey");
Song song4 = new Song("Like a Rolling Stone", "Bob Dylan", "Tom Wilson", "Bob Dylan");
Song song5 = new Song("Smells Like Teen Spirit", "Nirvana", "Butch Vig", "Kurt Cobain");



Playlist leleCano = new Playlist(song1);

leleCano.AddSong(song2);
leleCano.AddSong(song3);
leleCano.AddSong(song4);
leleCano.AddSong(song5);


Console.WriteLine(leleCano.GetSongs());

leleCano.ShuffleList();
Console.WriteLine("\n \n shufffffffffle");

Console.WriteLine(leleCano.GetSongs());

Console.WriteLine("\n \n write");

leleCano.PrintListNotepadWriter("C:\\Users\\seyyi\\Desktop\\Test.txt");