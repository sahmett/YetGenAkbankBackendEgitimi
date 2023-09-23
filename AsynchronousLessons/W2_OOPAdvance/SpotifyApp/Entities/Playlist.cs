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
        public string Name { get; private set; }

        private List<Song> Songs { get; set; }

        public Playlist()
        {
            Songs = new List<Song>();
        }
        public Playlist(Song firstsong) : this()
        { 
            AddSong(firstsong);
        }

        public void AddSong(Song song)
        {
            if(song!=null)
                Songs.Add(song);
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
    }
}
