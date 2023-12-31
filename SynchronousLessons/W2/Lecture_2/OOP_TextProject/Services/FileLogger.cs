﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OOP_TextProject.Common;
using OOP_TextProject.Entities;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public class FileLogger : LoggerBase
    {

        private readonly string _filePath; //readonly
        protected internal override string Name { get; set; } = "YetGen"; //varsayılan atama mantıgı
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }

        protected internal override void LogError(string message)
        {
            File.AppendAllText(_filePath, $"Hata => {message}");
        }

        protected internal override void LogInfo(string message)
        {
            File.AppendAllText(_filePath, $"Bilgi => {message}");
        }

        protected internal override void LogSuccess(string message)
        {
            File.AppendAllText(_filePath, $"Başarılı => {message}");
        }

        protected internal override void LogWarning(string message)
        {
            File.AppendAllText(_filePath, $"Hata => {message}");
        }

        protected internal override void LogFatal(string message)
        {
            File.AppendAllText(_filePath, $"Fatal => {message}");

            base.LogFatal(message); //base uzerinden çagırma
        }

    }
}