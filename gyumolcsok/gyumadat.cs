using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyumolcsok
{
    internal class gyumadat
    {
        int id;
        string nev;
        int egysegar;
        int mennyeiseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Egysegar { get => egysegar; set => egysegar = value; }
        public int Mennyeiseg { get => mennyeiseg; set => mennyeiseg = value; }

        public gyumadat(int id, string nev, int egysegar, int mennyeiseg)
        {
            Id = id;
            Nev = nev;
            Egysegar = egysegar;
            Mennyeiseg = mennyeiseg;
        }
        public override string ToString()
        {
            return nev + " " + mennyeiseg + " " + egysegar;
        }
    }
}
