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

        private List<string> Songs { get; set; }

        public Playlist()
        {
            Songs = new List<string>();
        }
        public Playlist(string name) : this()
        { 
            AddSong(name);
        }

        public void AddSong(string name)
        {
            if(IsSongTitleValid(name))
                Songs.Add(name);
        }

        private bool IsSongTitleValid(string name)
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
    }
}
