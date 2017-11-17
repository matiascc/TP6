using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.Domain
{
    class Document
    {
        public String Number { get; set; }

        public DocumentType Type { get; set; }
    }

    public enum DocumentType
    {
        DNI, CUIL, LC, LE
    }
}
