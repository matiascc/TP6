using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.DAL
{
    interface IUnitOfWork: IDisposable
    {
        void Complete();

        IAccountRepository AccountRepository { get; }
        IClientRepository ClientRepository { get; }
    }
}
