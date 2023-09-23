
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
var song1 = new Song("Huma Kuşu", "Artist 1", "Producer 1", "Composer 1");
var song2 = new Song("Song Title 2", "Artist 2", "Producer 2", "Composer 2");
var song3 = new Song("Song Title 3", "Artist 3", "Producer 3", "Composer 3");


Playlist leleCano = new Playlist(song1);

leleCano.AddSong(song2);
Console.WriteLine();

