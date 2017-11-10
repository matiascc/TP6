using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class Repository : IRepository
    {
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pContext)
        {

        }

        public void Add(TEntity pEntity) { }

        public TEntity Get(int pld) { }

        public IEnumerable<Tentity> GetAll() { }

        public void Remove(TEntity pEntity) { }
    }
}
