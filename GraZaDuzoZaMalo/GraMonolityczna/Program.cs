using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolityczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj swoje imię proszę: ");
            string imie = Console.ReadLine();

            Console.WriteLine($"Cześć {imie}!");
        }
    }
}
