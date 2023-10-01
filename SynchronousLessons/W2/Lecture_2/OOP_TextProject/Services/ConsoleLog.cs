using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Services
{
    public class ConsoleLog:LoggerBase
    {
        protected internal override void Log(string message) => Console.WriteLine($"{message}- {DateTime.Now:g}");

        protected internal override void LogSucces(string message);
        protected internal override void LogInfo(string message);
        protected internal override void LogError(string message);
        protected internal override void LogWarning(string message);
    }
}
