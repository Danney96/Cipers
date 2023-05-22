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
    public class Annons
    {
<<<<<<< HEAD
        
        public int? AnnonsId{ get; set; }
        public DateTime? AnnonsDatum { get; set; }
=======
        [Key]
        public int AnnonsId{ get; set; }
        public DateTime AnnonsDatum { get; set; }
>>>>>>> a5330c4a2c769925bebf82d60354aca7b59ffd2b

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


<<<<<<< HEAD

        [NotMapped] public Klädesplagg? Kön { get; set; }
=======
        [ForeignKey("Alias")]
        public Person SkapadAv { get; set; }
        [ForeignKey("Plats")]
        public Person Plats { get; set; }
        [ForeignKey("Kommun")]

        public Person Kommun { get; set; }
        [ForeignKey("PostNummer")]
        public Person PostNummer { get; set; }
>>>>>>> a5330c4a2c769925bebf82d60354aca7b59ffd2b

        public Annons()
        {

        }
        public Annons()
        {

        }
    }
}
