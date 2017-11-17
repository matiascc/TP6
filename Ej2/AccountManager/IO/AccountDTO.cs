using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.IO
{
    class AccountDTO
    {
        public int id { get; set; }
        public int name { get; set; }
        public int overDraftLimit { get; set; }
        public int balance { get; set; }
    }
}
