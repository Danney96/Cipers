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

        string Underkategori { get; set; }
        Klädesplagg Klädesplagg { get; set; }
        int? PlaggID { get; set; }
        Person Person { get; set; }
        long? PersonNummerID { get; set; }
        string Beskrivning { get; set; }
        float AnnonsPris { get; set; }
        bool Postas { get; set; }
        Skick Skick { get; set; }
    }
}
