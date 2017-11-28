using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Domain
{
    //Documento con tipo y numero
    public class Document
    {
        public String Number { get; set; }

        public DocumentType Type { get; set; }
    }

    //Tipos de documentos
    public enum DocumentType
    {
        DNI, CUIL, LC, LE
    }
}
