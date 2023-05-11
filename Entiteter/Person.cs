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
    public class Person
    {

        [Key]
        public long PersonNummerID { get; set; }
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public string Alias { get; set; }
        public string Kommun { get; set; }
        public string Plats { get; set; }
        public int PostNummer { get; set; }

        [NotMapped]
        public List<Annons>? AktivaAnnonser { get; set; }

        public List<Annons>? AnnonsHistorik { get; set; }

        
        public Person() 
        { 

        }

    }

}
