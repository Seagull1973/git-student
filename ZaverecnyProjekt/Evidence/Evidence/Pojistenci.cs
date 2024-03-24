using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Pojistenci
    {
        private string jmeno;
        private string prijmeni;
        private string telefon;
        private int vek;

        public Pojistenci(string jmeno, string prijmeni, string telefon, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.telefon = telefon;
            this.vek = vek;
        }
        public override string ToString()
        {
            return jmeno + " " + prijmeni + " " + telefon + " " + vek;
        }




    }
}
