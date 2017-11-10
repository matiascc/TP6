using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class ClientRepositrycs: Repository, IClientRepository
    {
        public ClientRepositrycs(AccountManagerRepository pContexto)
        {
                
        }
    }
}
