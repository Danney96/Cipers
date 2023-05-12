using Entiteter.Enums;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter.InterfaceKlasser
{
    public interface IKlädesplagg
    {
        int PlaggID { get; set; }
        string Färg { get; set; }
        float Nypris { get; set; }
        DateTime Inköpsdatum { get; set; }
        string Varumärke { get; set; }
        string ProduktNamn { get; set; }
        bool Annonserad { get; set; }
        Person Person { get; set; }
        Kön Kön { get; set; }
    }
}
