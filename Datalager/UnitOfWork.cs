using Entiteter;

namespace Datalager
{

    public class UnitOfWork
    {
        private KlädKontext context;
        //public Repository<Klädesplagg> KlädesplaggRepository
        //{
        //    get; private set;
        //}

        public Repository<Jeans> JeansRepository
        {
            get; private set;
        }

        public Repository<Tröja> TröjaRepository
        {
            get; private set;
        }

        public Repository<Annons> AnnonsRepository
        {
            get; private set;
        }

        public Repository<Person> PersonRepository
        {
            get; private set;
        }

        public Repository<Skor> SkorRepository
        {
            get; private set;
        }

        public Repository<Byxor> ByxorRepository
        {
            get; private set;
        }

        public UnitOfWork()
        {
            context = new KlädKontext();
            ByxorRepository = new Repository<Byxor>(context);
            SkorRepository = new Repository<Skor>(context);
            PersonRepository = new Repository<Person>(context);
            TröjaRepository = new Repository<Tröja>(context);
            JeansRepository = new Repository<Jeans>(context);
            //KlädesplaggRepository = new Repository<Klädesplagg>(context);
        }

        /// <summary>
        ///  Save the changes made. EDIT: now needed and implemented
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
