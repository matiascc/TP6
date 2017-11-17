using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly AccountManagerDbContext iDbContext;
        
        public UnitOfWork(AccountManagerDbContext pContext)
        {

        }

        public IAccountRepository<Account> AccountRepository => throw new NotImplementedException();

        public IClientRepository<Client> ClientRepository => throw new NotImplementedException();

        public void Complete() { }

        public void Dispose() { }
        
    }

}