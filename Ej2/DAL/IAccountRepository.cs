using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.DAL
{
    public interface IAccountRepository : IRepository<Account>
    {
        IEnumerable<Account> GetOverdrawnAccounts();
    }
}
