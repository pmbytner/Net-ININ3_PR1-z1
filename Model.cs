using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_ININ3_PR1_z1
{
    class JakaśKlasa
    {
        public string JakaśWłaściwość { get; set; }
    }
    class Model
    {
        public string Imię { get; set; } = "Nemo";
        public JakaśKlasa Coś { get; set; } = new();
        public string[] Tab { get; set; } = { "a", "b", "c" };
    }
}
