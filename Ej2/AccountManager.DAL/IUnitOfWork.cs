using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL
{
    interface IUnitOfWork: IDisposable
    {
        public void Complete(){}

        public IAccountRepository AccountRepository{get;}
        public IClientRepository ClientRepository{get;}
    }
}
