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
            string tiedosto = @"C:\tmp\Lämpötila.txt";

            // luetaan tiedostosta aiemmin asettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Asetettu lämpötila on " + aiempiArvo + " astetta");
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }
               
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte); // tarkastaa että syöte on numero

            // tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");         

            Console.ReadLine();

        }
    }
}
