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
    public class Annons
    {
        
        public int? AnnonsId{ get; set; }
        public DateTime? AnnonsDatum { get; set; }

        public string? Kategori;

        public string? Underkategori;

        public string? Beskrivning { get; set; }
        public float? AnnonsPris { get; set; }
        public bool? Postas { get; set; }
        public Skick? Skick { get; set; }
        public Klädesplagg? Storlek { get; set; }
        public Klädesplagg? Rubrik { get; set; }


        [NotMapped] 
        public Person? SkapadAv { get; set; }

        [NotMapped] public Person? Plats { get; set; }
        [NotMapped] public Person? Kommun { get; set; }
        [NotMapped] public Person? PostNummer { get; set; }



        [NotMapped] public Klädesplagg? Kön { get; set; }

        public Annons()
        {

        }
    }
}
