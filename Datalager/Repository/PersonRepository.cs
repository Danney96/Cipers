using Datalager.IRepository;
using Entiteter.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public KlädKontext KlädKontext { get; }
        public PersonRepository(KlädKontext klädKontext) : base(klädKontext)
        {
            KlädKontext = klädKontext;
        }
    }
}
