using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_ININ3_PR1_z1
{
    class Osoba
    {
        static uint następneID = 0;
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public uint Wiek { get; set; }
        public uint ID { get; }
        public Osoba()
        {
            ID = następneID;
            następneID++;
        }
    }
    class Model
    {
        public string[] Tab { get; set; } = { "a", "b", "c" };
        public LinkedList<Osoba> Lista { get; set; } = new(new Osoba[]{
            new(){Imię="Jan",Nazwisko="Kowalski",Wiek=30},
            new(){Imię="Anna",Nazwisko="Wiśniewska",Wiek=35},
            new(){Imię="Julia",Nazwisko="Jabłońska",Wiek=25}
        });
    }
}
