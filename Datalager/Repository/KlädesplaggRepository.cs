using Datalager.IRepository;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.Repository
{
    public class KlädesplaggRepository : Repository<Klädesplagg>, IKlädesplaggRepository
    {
        public KlädKontext KlädKontext { get; }
        public KlädesplaggRepository(KlädKontext klädKontext) : base(klädKontext)
        {
            KlädKontext = klädKontext;
        }
    }
}
