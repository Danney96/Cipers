using Datalager.IRepository;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.Repository
{
    public class SkorRepository : Repository<Skor>, ISkorRepository
    {
        public KlädKontext KlädKontext { get; }
        public SkorRepository(KlädKontext klädKontext) : base(klädKontext)
        {
            KlädKontext = klädKontext;
        }
    }
}
