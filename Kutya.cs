using System;
using System.Collections.Generic;
using System.Text;

namespace MenhelyCLI
{
    internal class Kutya
    {
        public Kutya(string l)
        {
            var r = l.Split(";");
            Nev = r[0];
            Fajta = r[1];
            Kor = int.Parse(r[2]);
            Suly = int.Parse(r[3]);
            Nem = r[4];
            Orokbefogadva = r[5] == "Igen" ? true : false;
        }

        public string Nev { get; set; }
        public string Fajta { get; set; }
        public int Kor { get; set; }
        public int Suly { get; set; }
        public string Nem { get; set; }
        public bool Orokbefogadva { get; set; }

        public override string ToString()
        {
            return $"{Nev} - {Fajta}, {Kor} éves, {Suly} kg";
        }

    }
}
