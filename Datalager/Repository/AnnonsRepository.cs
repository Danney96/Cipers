using Datalager.IRepository;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.Repository
{
    public class AnnonsRepository : Repository<Annons>, IAnnonsRepository
    {
        public KlädKontext KlädKontext { get; }
        public AnnonsRepository(KlädKontext klädKontext) : base(klädKontext)
        {
            KlädKontext = klädKontext;
        }
    }
}
