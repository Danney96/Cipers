using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datalager;
using Entiteter;

namespace Affärslager
{

    public class Kontroller
    {
        public Kontroller() { }

        public UnitOfWork UnitOfWork
        {
            get => default;
            set
            {
            }
        }

        public void Kör()
        {
            
            KlädKontext DbContext = new KlädKontext();
            DbContext.Database.EnsureDeleted();
            DbContext.Database.EnsureCreated();
        }
        public IList<Person> HämtaPerson()
        {

        }
    }

        
}
