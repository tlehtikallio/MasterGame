using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kysymykset
{
    class ProgramQuizzJ
    {
        static void Main(string[] args)
        {
            string menu;
            do
            {
            ListanLatausJaSekoitus();

            string pelaajanNimi;
            Kysymykset kys = new Kysymykset();
            Pelaaja print = new Pelaaja();
                Console.Clear();
            Console.WriteLine("Hei, kerro nimesi!");
            pelaajanNimi = Console.ReadLine();
                Console.Clear();

            kys.lueKysymykset();
            int kokonaispisteet = 0;
            

            kokonaispisteet = kys.kysyKysymys();
            Console.Clear();
            Console.WriteLine($"Kiitos pelaamisesta {pelaajanNimi}!");
            Console.WriteLine($"Sait {kokonaispisteet} / 10 oikein!");
            Console.WriteLine("Valikko");
            Console.WriteLine("1. Pelaa peli");
            Console.WriteLine("2. Lopeta peli");
            menu = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("KIITTIMOI!");


            } while (menu != "2");

            void ListanLatausJaSekoitus()
            {
                List<string> järjestyksessä;
                using (StreamReader lataus = new StreamReader("c://work//temp//kysymykset.txt", Encoding.GetEncoding("iso-8859-1")))
                {
                    järjestyksessä = new List<string>();
                    string rivi = lataus.ReadLine();
                    while (rivi != null)
                    {
                        järjestyksessä.Add(rivi);
                        rivi = lataus.ReadLine();
                    }
                }
                Random rng = new Random();
                string[] randomiksi = järjestyksessä.OrderBy(x => rng.Next()).ToArray();
                using (StreamWriter tallennus = new StreamWriter("c://work//kysymykset2.txt", false, Encoding.GetEncoding("iso-8859-1")))
                {
                    foreach (var r in randomiksi)
                    {
                        tallennus.WriteLine(r);
                    }
                }
                return;
            }
        }
    }
}
