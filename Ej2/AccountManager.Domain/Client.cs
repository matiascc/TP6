using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.Domain
{
    class Client
    {
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Document iDocumento { get; set; }

        public List<Account> lAccounts { get; set; }
    }
}
