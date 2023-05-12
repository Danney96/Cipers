using Datalager.IRepository;
using Datalager.Repository;
using Entiteter.Klasser;

namespace Datalager
{

    public class UnitOfWork : IUnitOfWork
    {
        private bool isDisposed = false;
        private readonly bool disposeContext = false;
        protected KlädKontext _dbContext { get; }

        private IPersonRepository person = null;
        public IPersonRepository Person => person ??= new PersonRepository(_dbContext);

        private IAnnonsRepository annons = null;
        public IAnnonsRepository Annons => annons ??= new AnnonsRepository(_dbContext);

        private IKlädesplaggRepository klädesplagg = null;
        public IKlädesplaggRepository Klädesplagg => klädesplagg ??= new KlädesplaggRepository(_dbContext);

        private ISkorRepository skor = null;
        public ISkorRepository Skor => skor ??= new SkorRepository(_dbContext);

        private IJeansRepository jeans = null;
        public IJeansRepository Jeans => jeans ??= new JeansRepository(_dbContext);
        private IByxorRepository byxor = null;
        public IByxorRepository Byxor => byxor ??= new ByxorRepository(_dbContext);
        private ITröjaRepository tröja = null;
        public ITröjaRepository Tröja => tröja ??= new TröjaRepository(_dbContext);

        //IPersonRepository IUnitOfWork.Person => person ??= new PersonRepository(_dbContext);

        //IAnnonsRepository IUnitOfWork.Annons => annons ??= new AnnonsRepository(_dbContext);

        //IKlädesplaggRepository IUnitOfWork.Klädesplagg => klädesplagg ??= new KlädesplaggRepository(_dbContext);

        //ISkorRepository IUnitOfWork.Skor => skor ??= new SkorRepository(_dbContext);

        //IByxorRepository IUnitOfWork.Byxor => byxor ??= new ByxorRepository(_dbContext);

        //ITröjaRepository IUnitOfWork.Tröja => tröja ??= new TröjaRepository(_dbContext);

        //IJeansRepository IUnitOfWork.Jeans => jeans ??= new JeansRepository(_dbContext);

        public UnitOfWork() : this(new KlädKontext())
        {
            disposeContext = true;
        }
        public UnitOfWork(KlädKontext bokningDbContext)
        {
            _dbContext = bokningDbContext;
        }
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                return;
            }
            if (disposing)
            {
                if (disposeContext)
                {
                    _dbContext.Dispose();
                }
            }
            isDisposed = true;
        }

        
        ~UnitOfWork()
        {
            Dispose(false);
        }


        //private KlädKontext context;
        //public Repository<Klädesplagg> KlädesplaggRepository
        //{
        //    get; private set;
        //}

        //public Repository<Jeans> JeansRepository
        //{
        //    get; private set;
        //}

        //public Repository<Tröja> TröjaRepository
        //{
        //    get; private set;
        //}

        //public Repository<Annons> AnnonsRepository
        //{
        //    get; private set;
        //}

        //public Repository<Person> PersonRepository
        //{
        //    get; private set;
        //}

        //public Repository<Skor> SkorRepository
        //{
        //    get; private set;
        //}

        //public Repository<Byxor> ByxorRepository
        //{
        //    get; private set;
        //}

        //public UnitOfWork()
        //{
        //    context = new KlädKontext();
        //    ByxorRepository = new Repository<Byxor>(context);
        //    SkorRepository = new Repository<Skor>(context);
        //    PersonRepository = new Repository<Person>(context);
        //    TröjaRepository = new Repository<Tröja>(context);
        //    JeansRepository = new Repository<Jeans>(context);
        //    KlädesplaggRepository = new Repository<Klädesplagg>(context);
        //    AnnonsRepository = new Repository<Annons>(context);
        //}

        ///// <summary>
        /////  Save the changes made. EDIT: now needed and implemented
        ///// </summary>
        //public void Save()
        //{
        //    context.SaveChanges();
        //}
    }
}
