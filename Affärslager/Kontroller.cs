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
        public UnitOfWork unitofwork = new UnitOfWork();
        public Kontroller() { }

        public void Kör()
        {
            
            KlädKontext DbContext = new KlädKontext();
            DbContext.Database.EnsureDeleted();
            DbContext.Database.EnsureCreated();
        }
    }

        
}
