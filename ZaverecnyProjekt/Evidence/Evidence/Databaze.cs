using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Databaze
    { 
        private List<Pojistenci> pojistenciList; 

        public Databaze() 
        {
            pojistenciList = new List<Pojistenci>();  
        }
        public void PridejPojisteneho(string jmeno, string prijmeni, string telefon, int vek)
        {
            pojistenciList.Add(new Pojistenci( jmeno, prijmeni, telefon, vek));
        } 
        public List<Pojistenci> VypisVsechnyPojistene()
        {
            return pojistenciList; 
        } 
        public List<Pojistenci>  VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            foreach (Pojistenci p in pojistenciList)
            {
                if(p.jmeno == jmeno && p.prijmeni == prijmeni)
                {
                    return p;
                }
            } 
            return pojistenciList;
        }
        
            
        



    }
}
