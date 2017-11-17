﻿using Ej2.AccountManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej2.AccountManager.DAL.EntityFramework
{
    class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository
    {
        public ClientRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }
    }
}
