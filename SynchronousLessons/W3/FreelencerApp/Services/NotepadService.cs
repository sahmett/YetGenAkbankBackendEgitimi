using FreelencerApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelencerApp.Common;
using FreelencerApp.Constants;
using FreelencerApp.Entities;

namespace FreelencerApp.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data) 
        {
            string path = $"{FileLocations.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(',').LastOrDefault() ;

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data.GetValueCSV()}\n");
        }

        public string GetOnNotepad(string path) 
        {
            if(File.Exists(path))
            {
                return File.ReadAllText(path);
                
            }

            throw new Exception("file doesn't exist");
            
        }
    }
}