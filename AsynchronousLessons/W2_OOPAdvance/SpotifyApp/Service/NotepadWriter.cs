using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Service
{
    internal class NotepadWriter
    {
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

