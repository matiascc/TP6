using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Domain
{
    public class Client
    {
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Document Document { get; set; }

        public virtual IList<Account> Accounts { get; set; }
    }
}
