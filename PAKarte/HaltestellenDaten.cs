using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKarte
{
    public class HaltestellenDaten
    {
        public int NR { get; set; }
        public string Name { get; set; }

        public double Laenge { get; set; }

        public double Breite { get; set; }

        public HaltestellenDaten(int nr, string name, double laenge, double breite)
        {
            NR = nr;
            Name = name;
            Laenge = laenge;
            Breite = breite;
        }

        public bool isHbf(string name)
        {
            if (name.Contains("Hbf"))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return "EVA_NR = " + NR + "# Name: " + Name + " # Länge: " + Laenge + " # Breite: " + Breite;
        }
    }
}
