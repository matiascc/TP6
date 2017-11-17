using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class Repository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class where TDbContext : DbContext
    {
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pContext)
        {

        }

        public void Add(TEntity pEntity) { }

        public TEntity Get(int pld) { }

        public IEnumerable<TEntity> GetAll() { }

        public void Remove(TEntity pEntity) { }
    }
}
