using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTransportApp.Services
{
    internal class NotepadServices
    {
        public string ReadFromNotepad(string _path)
        {
            if (File.Exists(_path ))
                return File.ReadAllText(_path);


            throw new Exception("file not found");

          
        }
    }
}
