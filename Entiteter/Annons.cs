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
        
        public int AnnonsId{ get; set; }
        public DateTime AnnonsDatum { get; set; }

        public string Kategori;

        public string Underkategori;

        public string Beskrivning { get; set; }
        public float AnnonsPris { get; set; }
        public bool Postas { get; set; }
        public Skick Skick { get; set; }

        [NotMapped]
        public Klädesplagg Storlek { get; set; }
        [NotMapped]
        public Klädesplagg Rubrik { get; set; }


        [NotMapped]
        public Person SkapadAv { get; set; }
        [NotMapped]
        public Person Plats { get; set; }
        [NotMapped]
        public Person Kommun { get; set; }
        [NotMapped]
        public Person PostNummer { get; set; }

        
        
        public Klädesplagg Kön { get; set; }

        public Annons(int annonsID, DateTime annonsDatum, string kategori, string underkategori, string beskrivning, float annonsPris, bool postas, Skick skick, Klädesplagg storlek, Klädesplagg rubrik, Person skapadAv, Person plats, Person kommun, Person postNummer, Klädesplagg kön)
        {
            AnnonsId= annonsID;
            AnnonsDatum = annonsDatum;
            Kategori = kategori;
            Underkategori = underkategori;
            Beskrivning = beskrivning;
            AnnonsPris = annonsPris;
            Postas = postas;
            Skick = skick;
            Storlek = storlek;
            Rubrik = rubrik;
            SkapadAv = skapadAv;
            Plats = plats;
            Kommun = kommun;
            PostNummer = postNummer;
            Kön = kön;
        }
        public Annons()
        { }
    }
}
