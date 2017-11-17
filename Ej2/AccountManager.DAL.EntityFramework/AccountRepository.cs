using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class AccountRepository<TEntity, TDbContext> : Repository<TEntity, TDbContext>, IAccountRepository<TEntity> where TEntity : Account where TDbContext : AccountManagerDbContext
    {
        public AccountRepository(TDbContext pContext) : base(pContext)
        {

        }

        public IEnumerable<Account> GetOverdrawnAccounts() { }
    }
}
