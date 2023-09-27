using FreelencerApp.Common;
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
        

    }
}
