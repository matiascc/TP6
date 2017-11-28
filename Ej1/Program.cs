using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (AgendaContext contexto = new AgendaContext())
                {
                    //Alta Persona
                    Persona mPersona = new Persona
                    {
                        PersonaId = 1,
                        Nombre = "Juan",
                        Apellido = "Sanchez",
                        Telefonos = new List<Telefono>
                        {
                            new Telefono
                            {
                                TelefonoId = 1,
                                Numero = "555-123456",
                                Tipo = "Celular"
                            }
                        }
                    };

                    contexto.Personas.Add(mPersona);    //Agrega una persona a la base de datos.

                    contexto.SaveChanges();             //Guarda los datos.

                    //Listado Personas.
                    foreach(Persona item in contexto.Personas)
                    {
                        Console.WriteLine("Id {0} - Nombre {1} - Apellido {2}", item.PersonaId, item.Nombre, item.Apellido);
                    }

                }
            }
            catch(Exception bEx)
            {
                Console.WriteLine("Se ha producido un Error", bEx);
            }

            Console.ReadLine();
        }
    }
}
