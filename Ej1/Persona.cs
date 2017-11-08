using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Persona
    {
        public int PersonaId { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public virtual IList<Telefono> Telefonos { get; set; }
    }
}
