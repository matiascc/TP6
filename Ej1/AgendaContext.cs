using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    //Contexto de la base de datos donde se crean las tablas.
    class AgendaContext : DbContext
    {
        
        public IDbSet<Persona> Personas { get; set; }

        public IDbSet<Telefono> Telefono { get; set; }
    }
}
