using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace EvidencePojisteni
{
    internal class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }
        public void PridejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))  // ošetření vstupu od uživatele
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadejte příjmení");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))  // ošetření vstupu od uživatele
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadejte telefonní číslo:");
            string telefon;
            telefon = Console.ReadLine();
            if (telefon != null)
            {
                Console.WriteLine("Chybné zadání, zadejte číslo znovu");
            }
            Console.WriteLine("Zadejte věk");
            int vek;
            vek = Console.ReadLine()
            {
                return string;
            }
        }

        public void VypisVsechnyPojistene()
        {
            List<Pojistenci> pojistenci = new List<Pojistenci>();
            foreach (Pojistenci p in pojistenci)
                Console.WriteLine(p);
        }
        public void VyhledejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))  // ošetření vstupu od uživatele
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadejte příjmení");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))  // ošetření vstupu od uživatele
            {
                Console.WriteLine("Zadej text znovu:");
            }
            List<Pojistenci> pojistenci = new List<Pojistenci>();
            foreach (Pojistenci p in pojistenci)
                Console.WriteLine(p);
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("-------------------\n" +
                "Evidence pojištěných\n" +
                "--------------------");

            Console.WriteLine();








        }
    }
}
