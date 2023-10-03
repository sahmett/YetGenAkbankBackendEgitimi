﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOP_TextProject.Common;
using OOP_TextProject.Entities;

namespace OOPConsoleApp.Entities
{
    public class Student : PersonBase
    {
        public int No { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
