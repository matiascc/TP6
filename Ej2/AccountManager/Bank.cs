using Ej2.AccountManager.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager
{
    abstract class Bank
    {
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            
        }


        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {

        } 
    }
}
