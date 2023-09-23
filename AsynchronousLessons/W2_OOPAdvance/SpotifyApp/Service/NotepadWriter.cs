using SpotifyApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Service
{
    public class NotepadWriter
    {
        public void PlaylistWriter(Playlist playlist)
        {
            string directory = $@"{Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent?.Parent?.FullName}\Service";
            
            if(!File.Exists(directory))
                Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Name}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("data successfully saved to notepad");
        }

        public void writeNotepad(string _path, string _body)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(_path);
                //Write a line of text
                sw.WriteLine(_body);
                //Write a second line of text
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public void writeNotepad2(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true)) // true ile dosyanın sonuna ekleme yapar
                {
                    writer.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

