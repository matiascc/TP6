using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL
{
    interface IAccountRepository<TEntity> where TEntity : Account
    {
        IEnumerable<Account> GetOverdrawnAccounts();
    }
}
