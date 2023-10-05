using LibraryMaster.Abstract;
using LibraryMaster.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Service
{
    internal class NotepadService
    {
        
        public void SaveToNotepad(ISaveable data)
        {
            string path = $"{FileLocations.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault();


            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}s.txt";

            string[] lines = new string[] { data.GetValues() };

            File.AppendAllLines(filePath, lines);
            
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("Dosya mevcut değil");
        }
    }
}
