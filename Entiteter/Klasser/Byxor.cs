using Entiteter.Enums;
using Entiteter.InterfaceKlasser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter.Klasser
{
    public class Byxor : Klädesplagg , IByxor
    {
        public string Storlek { get; set; } = null!;
        public string Passform { get; set; } = null!;
        //public Byxor(string storlek, string passform, int plaggID, string färg, float nypris, DateTime inköpsdatum, string varumärke, string produktNamn, bool annonserad, Kön kön) : base()
        //{
        //    Storlek = storlek;
        //    Passform = passform;
        //    PlaggID = plaggID;
        //    Färg = färg;
        //    Nypris = nypris;
        //    Inköpsdatum = inköpsdatum;
        //    Varumärke = varumärke;
        //    ProduktNamn = produktNamn;
        //    Annonserad = annonserad;
        //    Kön = kön;
        //}
        //public Byxor() { }
    }
}
