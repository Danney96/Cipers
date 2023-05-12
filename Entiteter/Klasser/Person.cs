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
    public class Person : IPerson
    {

        [Key]
        public long PersonNummerID { get; set; }
        public string FörNamn { get; set; } = null!;
        public string EfterNamn { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string Kommun { get; set; } = null!;
        public string Plats { get; set; } = null!;
        public int PostNummer { get; set; }

        //[NotMapped]
        //public List<Annons>? AktivaAnnonser { get; set; }

        public virtual IList<Annons>? AnnonsHistorik { get; set; } = new List<Annons>();

        public virtual IList<Klädesplagg>? Garderob { get; set; } = new List<Klädesplagg>();
        
    }

}
