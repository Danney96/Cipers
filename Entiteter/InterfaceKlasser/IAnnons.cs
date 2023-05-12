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
    public interface IAnnons
    {
        int AnnonsId { get; set; }
        DateTime AnnonsDatum { get; set; }

        string Kategori { get; set; }
        string? SkapadAv { get; set; }
        string Underkategori { get; set; }
        int? PlaggID { get; set; }
        int? PostNr { get; set; }
        string? Kön { get; set;  }
        string? Rubrik { get; set; }
        string? Kommun { get; set; }
        string? Plats { get; set; }
        string Beskrivning { get; set; }
        float AnnonsPris { get; set; }
        bool Postas { get; set; }
        Skick Skick { get; set; }
    }
}
