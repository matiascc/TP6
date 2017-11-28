using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej2.DAL.EntityFramework
{
    //Repositorio de los clientes.
    class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository
    {
        public ClientRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }
    }
}
