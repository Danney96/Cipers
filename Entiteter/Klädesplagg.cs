using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entiteter.Enums;

namespace Entiteter
{
    public class Klädesplagg
    {
        public string Storlek { get; set; }
        public string Färg { get; set; }
        public float Nypris { get; set; }
        public DateTime Inköpt { get; set; }
        public string PassForm { get; set; }
        public string Märke { get; set; }
        public string ProduktBeskrivning { get; set; }
        public string ProduktNamn { get; set; }
        public TypAvPlagg TypAvPlagg { get; set; }
        public float AndraHandsVärde { get; set; }
        public bool Annonserad { get; set; }
        public Kön Kön { get; set; }
        
        public Klädesplagg(string storlek, string färg, float nypris, DateTime inköpt,string passForm, string märke, string produktBeskrivning, string produktNamn, float andraHandsVärde)
        {

        }

        //public SkapaAnnons()


        




    }

}
