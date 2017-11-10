using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL.EntityFramework
{
    class AccountManagerDbContext : DbContext 
    {
        public DbSet Clients { get; set; }

        public DbSet Accounts { get; set; }

        public DbSet AccountMovements { get; set; }
    }
}
