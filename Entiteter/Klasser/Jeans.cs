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
    public class Jeans : Klädesplagg, IJeans
    {
        public string Passform { get; set; } = null!;
        public int Längdmått { get; set; }
        public int Midjemått { get; set; }
        //public Jeans(string passform, int längdmått, int midjemått, int plaggID, string färg, float nypris, DateTime inköpsdatum, string varumärke, string produktNamn, bool annonserad, Kön kön, Person person) : base()
        //{
        //    Passform = passform;
        //    Längdmått = längdmått;
        //    Midjemått = midjemått;
        //    PlaggID = plaggID;
        //    Färg = färg;
        //    Nypris = nypris;
        //    Inköpsdatum = inköpsdatum;
        //    Varumärke = varumärke;
        //    ProduktNamn = produktNamn;
        //    Annonserad = annonserad;
        //    Kön = kön;
        //    Person = person;
        //}

        //public Jeans()
        //{
        //}
    }
}
