using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Person
    {

        private int PersonNummerID { get; set; }
        private string FörNamn { get; set; }
        private string EfterNamn { get; set; }
        public string Alias { get; set; }
        public string Kommun { get; set; }
        public string Plats { get; set; }
        public int PostNummer { get; set; }
        
        public List<Annons> AktivaAnnonser { get; set; }

        public int AnnonsHistorik { get; set; }

        
        public Person() 
        { 

        }

    }

}
