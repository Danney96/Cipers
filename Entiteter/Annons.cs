using Entiteter.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Annons
    {
        
        public Person SkapadAv { get; set; }

        public string Kategori;

        public string Underkategori;
        public Klädesplagg Storlek { get; set; }
        public Skick Skick { get; set; }
        public float AnnonsPris {get; set; }
        public Person Plats { get; set; }
        public Person Kommun { get; set; }
        public Person PostNummer { get; set; }
        public Klädesplagg TypAvPlagg { get; set; }
        
        public Klädesplagg Kön { get; set; }
        public bool Postas { get; set; }

        
    }
}
