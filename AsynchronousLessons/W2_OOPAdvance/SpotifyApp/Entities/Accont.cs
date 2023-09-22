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
        //public int Balance { get; private set; }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set
            {
                if (Math.Abs(value - Balance) <= 500)
                {                      
                    balance = (value);
                    Console.WriteLine($"1 Profit - Payment taken, New Balance: {Balance}");
                }
                else { Console.WriteLine("1 Profit - Not enough balance, sorry :'( "); }
            }
        }


        public Accont(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Guid.NewGuid();
            balance = 2000;
        }
        #region payment sys
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
        #endregion
    }
}
