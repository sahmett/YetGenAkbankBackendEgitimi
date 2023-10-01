using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Services
{
    public class FileLogger:LoggerBase
    {
        public readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }

        protected internal override void LogSucces(string message);
        protected internal override void LogInformation(string message);
        protected internal override void LogError(string message);
        protected internal override void LogWarning(string message);
    }
}
