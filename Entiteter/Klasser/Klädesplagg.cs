using Entiteter.Enums;
using Entiteter.InterfaceKlasser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter.Klasser
{
    public class Klädesplagg : IKlädesplagg
    {
        [Key]
        public int PlaggID { get; set; }
        public string Färg { get; set; } = null!;
        public float Nypris { get; set; }
        public DateTime Inköpsdatum { get; set; }
        public string Varumärke { get; set; } = null!;
        public string ProduktNamn { get; set; } = null!;
        public bool Annonserad { get; set; }
        [ForeignKey("Person")]
        public long? Tillhör { get; set; }

        [ForeignKey("Byxor")]
        public string? bStorlek { get; set; } = null!;
        [ForeignKey("Jeans")]
        public string? Jstorlek { get; set; } = null!;
        [ForeignKey("Skor")]
        public int? Sstorlek { get; set; } = null!;
        [ForeignKey("Tröja")] 
        public string? Tstorlek { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        
        public Kön Kön { get; set; }
        
    }

}
