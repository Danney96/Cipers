using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter.InterfaceKlasser
{
    public interface IPerson
    {
         long PersonNummerID { get; set; }
         string FörNamn { get; set; } 
         string EfterNamn { get; set; } 
         string Alias { get; set; } 
         string Kommun { get; set; } 
         string Plats { get; set; } 
         int PostNummer { get; set; }

        //[NotMapped]
        // List<Annons>? AktivaAnnonser { get; set; }

         IList<Annons>? AnnonsHistorik { get; set; }

         IList<Klädesplagg>? Garderob { get; set; }

    }
}
