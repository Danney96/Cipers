using Entiteter.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public abstract class Klädesplagg
    {
        [Key]
        public int PlaggID { get; set; }
        public string Färg { get; set; }
        public float Nypris { get; set; }
        public DateTime Inköpsdatum { get; set; }
        public string Varumärke { get; set; }
        public string ProduktNamn { get; set; }
        public bool Annonserad { get; set; }
        public Kön Kön { get; set; }
        public Klädesplagg()
        {

        }

    }

}
