using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL
{
    interface IUnitOfWork: IDisposable
    {
        void Complete();

        IAccountRepository<Account> AccountRepository { get; }
        IClientRepository<Client> ClientRepository { get; }
    }
}
