using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Services
{
    public abstract class LoggerBase
    {
        protected internal abstract void Log(string message);
        protected internal abstract void LogSucces(string message);
        protected internal abstract void LogInfo(string message);
        protected internal abstract void LogError(string message);
        protected internal abstract void LogWarning(string message);




    }
}
