using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT2_Q8E6EZ
{
    public class KavezoAdat
    {
        //KavezoID,Nev,Varos,NapiLatogatok,ProfitEZREuro
        public int KavezoID { get; set; }
        public string Nev { get; set; }=string.Empty;
        public string Varos { get; set; } = string.Empty;
        public int NapiLatogatok { get; set; }
        public double ProfitEZREuro { get; set; }
    }
}
