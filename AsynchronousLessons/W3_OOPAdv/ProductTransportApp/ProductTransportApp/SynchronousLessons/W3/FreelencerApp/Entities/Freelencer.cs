﻿using FreelencerApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelencerApp.Entities
{
    internal class Freelencer : Person<Guid>
    {
        public string WorkExperience { get; set; }
        public List<Review> Reviews { get; set;}

        //todo Skills

        public string GetValuesCVS()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{WorkExperience}";
        }


        //522af243-34ff-42d8-b98c-16beeb014487,9/25/2023 9:58:57 PM +03:00,John,Doe,5 years of experience in web development

        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]); //offset ile farkı ne?
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];

        }

        //todo: Preferred Price
        //todo: Skills
    }
}
