using Ej2.DAL.EntityFramework.Mappings;
using Ej2.Domain;
using System.Data.Entity;

namespace Ej2.DAL.EntityFramework
{
    //Contexto de la base de datos, con las respectivas tablas que la componen.
    public class AccountManagerDbContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountMovement> AccountMovements { get; set; }

        public AccountManagerDbContext() : base("AccountManagerContext")
        {
           // Se establece la estrategia personalizada de inicialización de la BBDD.
            Database.SetInitializer<AccountManagerDbContext>(new DatabaseInitializationStrategy());
        }

        //Agrega las clases de mapeo de las tablas a la configuracion.
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.Add(new ClientMap());
            pModelBuilder.Configurations.Add(new AccountMap());
            pModelBuilder.Configurations.Add(new AccountMovementMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
