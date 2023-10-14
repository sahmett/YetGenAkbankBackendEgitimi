// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;


Console.WriteLine("Hello, World!");


int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



Console.WriteLine("\n kucukSayilar1 ");

var kucukSayilar1 = from sayi in sayilar
                    where sayi > 5
                    select sayi;

foreach (int sayi in kucukSayilar1)
{
    Console.Write($"{sayi},");
}



Console.WriteLine("\n kucukSayilar2 ");


var kucukSayilar2 = sayilar.Where(x => x < 5);

foreach (int sayi in kucukSayilar2)
{
    Console.Write($"{sayi},");
}
Console.Write("");