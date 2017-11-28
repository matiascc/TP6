using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.DAL.EntityFramework
{
    //Repositorio de las cuentas.
    class AccountRepository : Repository<Account, AccountManagerDbContext>, IAccountRepository
    {
        public AccountRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }

        //Devuelve el balance de una cuenta pasada por parametro.
        public double GetAccountBalance(Account pAccount)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.Sum(pMovement => pMovement.Amount);
        }

        //Devuelve los ultimos 7 movimientos de una cuenta.
        public IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.OrderBy(pMovement => pMovement.Date).Take(pCount);
        }
        
        //Devuelve cuentas con deuda.
        public IEnumerable<Account> GetOverdrawnAccounts()
        {
            return from account in this.iDbContext.Set<Account>()
                   select new { Account = account, Balance = account.Movements.Sum(pMovement => pMovement.Amount) } into accountWithBalance
                   where accountWithBalance.Balance < 0 && Math.Abs(accountWithBalance.Balance) > accountWithBalance.Account.OverdraftLimit
                   select accountWithBalance.Account;
        }
    }
}
