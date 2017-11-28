using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    //Contexto de la base de datos, con las respectivas tablas que la componen.
    class AgendaContext : DbContext
    {
        public IDbSet<Persona> Personas { get; set; }

        public IDbSet<Telefono> Telefono { get; set; }
    }
}
