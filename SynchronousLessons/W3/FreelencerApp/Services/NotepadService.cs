using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelencerApp.Services
{
    internal class NotepadService
    {

        public void SaveToNotepad(string path, string data)
        {
            File.WriteAllText($"{path}\\Deneeme.txt", data);
        }
    }
}