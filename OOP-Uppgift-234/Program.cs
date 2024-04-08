using OOP_Uppgift_2;
using System;

namespace Uppgift2
{
    class Program
    {
        static void Main()
        {
            Namn namn2 = new("David", "Davidsson", new DateTime(1990, 01, 01), 60, 175);
            Console.WriteLine(namn2.SetNamn + " " + namn2.setDatum + " " + namn2.KontrolleraDatum() + " " + namn2.BMI());
        }
    }
}