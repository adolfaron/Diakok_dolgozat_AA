using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diakok_dolgozat_AA.Model
{
    internal class Diak
    {
        

        public int Id { get; set; }
        public string Nev { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public double Atlag { get; set; }
        public bool Bajai { get; set; }
        public static int DiakokSzama { get; set; }


        public Diak(int id, string nev, string nem, int szuletesiEv, double atlag, bool bajai = true)
        {
            Id = id;
            Nev = nev;
            Nem = nem;
            SzuletesiEv = szuletesiEv;
            Atlag = atlag;
            Bajai = bajai;
            DiakokSzama++;
        }

        public Diak()
        {
            DiakokSzama++;
        }

        public int Eletkor()
        {
            return DateTime.Now.Year-SzuletesiEv;
        }
        public override string ToString()
        {
            return $"Diak azonosítója {Id}, neve: {Nev}, {Nem}, születési éve: {SzuletesiEv}, Átlaga: {Math.Round(Atlag, 1)} és {(Bajai?"":"nem ")}Baján lakik.";
        }
        public static string LetszamSzoveg()
        {
            return $"Összesen {DiakokSzama} fő jár az osztályba!";
        }


    }
}
