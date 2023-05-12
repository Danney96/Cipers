using Datalager.IRepository;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.Repository
{
    public class TröjaRepository : Repository<Tröja>, ITröjaRepository
    {
        public KlädKontext KlädKontext { get; }
        public TröjaRepository(KlädKontext klädKontext) : base(klädKontext)
        {
            KlädKontext = klädKontext;
        }
    }
}
