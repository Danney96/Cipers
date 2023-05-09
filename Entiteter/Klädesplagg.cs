using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entiteter.Enums;

namespace Entiteter
{
    public abstract class Klädesplagg
    {
        public int PlaggID { get; set; }
        public string Färg { get; set; }
        public float Nypris { get; set; }
        public DateTime Inköpsdatum { get; set; }
        public string Varumärke { get; set; }
        public string ProduktNamn { get; set; }
        public bool Annonserad { get; set; }
        public Kön Kön { get; set; }

    }

}
