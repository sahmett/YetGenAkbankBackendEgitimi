using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

new MyEntity();

class MyEntity
{
    public string Id { get; set; }

    #region RAND ID
    /* 
     public MyEntity()
    {
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            Id += (char)random.Next(48, 90);
        }
        Console.WriteLine($"uretilen ID: {Id}");
    }
    
    */
    #endregion
    public MyEntity()
    {
        Id = Guid.NewGuid().ToString();
        Console.WriteLine(Id);
    
    }
}
