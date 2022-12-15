using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Osoba
    {
        string jmeno;
        string prijmeni;
        DateTime datumNastupu;
        TimeSpan OdpracHodin;
        double HodinovaMzda = 0;
        public Osoba(string jmeno, string prijmeni, double HodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.HodinovaMzda = HodinovaMzda;
            datumNastupu = DateTime.Now;
            OdpracHodin.Hours = 0;
        }
        public string pocet_dni()
        {
            OdpracHodin = DateTime.Now - datumNastupu;
            double hours = OdpracHodin.Hours;
            return "pocet dni ktery je odpracovan: " + (hours/24) + "a ani o den vic";
        }
        public string mzda()
        {
            double money = int.Parse(HodinovaMzda * OdpracHodin);
            return "mzda zamestnance je:" + (money) + "KC";
        }

    }
}
