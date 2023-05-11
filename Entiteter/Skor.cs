using Entiteter.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Skor : Klädesplagg
    {
        public int Storlek { get; set; }
        public string Skotyp { get; set; }
        public string Modell { get; set; }
        public Skor(int storlek, string skotyp, string modell, int plaggID, string färg, float nypris, DateTime inköpsdatum, string varumärke, string produktNamn, bool annonserad, Kön kön) : base()
        {
            Storlek = storlek;
            Skotyp = skotyp;
            Modell = modell;
            PlaggID = plaggID;
            Färg = färg;
            Nypris = nypris;
            Inköpsdatum = inköpsdatum;
            Varumärke = varumärke;
            ProduktNamn = produktNamn;
            Annonserad = annonserad;
            Kön = kön;
        }
        public Skor()
        {

        }
    }
}
