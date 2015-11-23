using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte); // tarkastaa että syöte on numero

            // tiedostoon kirjoittaminen

            string tiedosto = @"C:\tmp\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            

            Console.ReadLine();

        }
    }
}
