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


// Example 1: Select
Console.WriteLine("\nExample 1: Select");

var squaredNumbers = sayilar.Select(x => x * x);

foreach (int squaredNumber in squaredNumbers)
{
    Console.Write($"{squaredNumber},");
}
Console.WriteLine();


//More Examples:

// Example 2: OrderBy
Console.WriteLine("\nExample 2: OrderBy");

var orderedNumbers = sayilar.OrderBy(x => x);

foreach (int number in orderedNumbers)
{
    Console.Write($"{number},");
}
Console.WriteLine();

// Example 3: Any
Console.WriteLine("\nExample 3: Any");

bool hasEvenNumber = sayilar.Any(x => x % 2 == 0);
Console.WriteLine($"Has even number: {hasEvenNumber}");

// Example 4: Sum
Console.WriteLine("\nExample 4: Sum");

int sumOfNumbers = sayilar.Sum();
Console.WriteLine($"Sum of numbers: {sumOfNumbers}");
