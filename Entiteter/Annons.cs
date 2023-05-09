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
        
        public int AnnonsId{ get; set; }
        public DateTime AnnonsDatum { get; set; }

        public string Kategori;

        public string Underkategori;

        public string Beskrivning { get; set; }
        public float AnnonsPris { get; set; }
        public bool Postas { get; set; }
        public Skick Skick { get; set; }
        public Klädesplagg Storlek { get; set; }
        public Klädesplagg Rubrik { get; set; }



        public Person SkapadAv { get; set; }
        public Person Plats { get; set; }
        public Person Kommun { get; set; }
        public Person PostNummer { get; set; }

        
        
        public Klädesplagg Kön { get; set; }

        public Annons(DateTime annonsDatum, string kategori, string underkategori, string beskrivning, float annonsPris, bool postas, Skick skick, Klädesplagg storlek, Klädesplagg rubrik, Person skapadAv, Person plats, Person kommun, Person postNummer, Klädesplagg kön)
        {

            AnnonsDatum = annonsDatum;
            Kategori = kategori;
            Underkategori = underkategori;
            Beskrivning = beskrivning + "\n" + storlek;
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
    }
}
