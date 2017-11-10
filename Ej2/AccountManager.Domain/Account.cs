using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.Domain
{
    class Account
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public Client iCliente { get; set; }

        public AccountMovement Movements { get; set; }

        public double GetBalance() { }

        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7) { }

        



    }
}
