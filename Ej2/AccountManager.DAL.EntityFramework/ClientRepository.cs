using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej2.AccountManager.DAL.EntityFramework
{
    class ClientRepository<TEntity, TDbContext> : Repository<TEntity, TDbContext>, IClientRepository<TEntity> where TEntity : Client where TDbContext : AccountManagerDbContext
    {
        public ClientRepository(TDbContext pContext) : base(pContext)
        {
            
        }

        public IEnumerable<Client> GetOverdrawnAccounts() { }
    }
}
