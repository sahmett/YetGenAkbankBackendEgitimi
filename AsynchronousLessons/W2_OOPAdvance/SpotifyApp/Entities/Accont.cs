using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Entities
{
    public class Accont
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Balance { get; set; }

        public Accont(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Guid.NewGuid();
            Balance = 1110;
        }

        public void paymentSys(decimal payment)
        {
            if(Balance - payment >= 0) { 
                Balance -= (int)(payment);
                Console.WriteLine($"Payment taken, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Not enough balance, sorry :'( ");
            }
        }
    }
}
