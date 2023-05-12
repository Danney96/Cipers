using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Person { get; }
        IAnnonsRepository Annons { get; }
        IKlädesplaggRepository Klädesplagg { get; }
        ISkorRepository Skor { get; }
        IByxorRepository Byxor { get; }
        ITröjaRepository Tröja { get; }
        IJeansRepository Jeans { get; }

        int Complete();
    }
}
