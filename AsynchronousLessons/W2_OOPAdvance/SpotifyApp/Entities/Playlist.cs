using SpotifyApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private List<Song> Songs { get; set; }

        private Random random;

        public Playlist(Song firstsong) 
        {
            Songs = new List<Song>();
            AddSong(firstsong);
            random = new Random();
        }

        public void AddSong(Song song)
        {
            if(song!=null)
                Songs.Add(song);
        }

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(x => $"{x.Title} - {x.Artist} - {x.Producer} - {x.Composer}"));
        }

        /*private bool IsSongTitleValid(string name)
        {
            return
                !string.IsNullOrEmpty(name)
                && name.Length > 2
                && name.Length < 10;
        }
        

        public void PrintList()
        {
            foreach(var song in Songs)
            {
                Console.WriteLine(song);
            }
        }
        */

        public void ShuffleList()
        {
            int count = Songs.Count;
            while(count > 0)
            {
                count--;

                Song song = Songs[count];
                int randomIndex = random.Next(0, count);
                Songs[count] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }

        public void PrintListNotepadWriter(string path)
        {
            foreach (var song in Songs)
            {
                Console.WriteLine(song);
                var np = new NotepadWriter();
                np.writeNotepad2(path, song.Title);
            }
        }
    }
}
