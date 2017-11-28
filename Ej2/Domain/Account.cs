using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Domain
{
    //Cuenta
    public class Account
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public virtual Client Cliente { get; set; }

        public virtual IList<AccountMovement> Movements { get; set; }

        // Obtiene el balance de la cuenta
        public double GetBalance()
        {
            return this.Movements.Sum(t => t.Amount);
        }

        // Obtiene los ultimos 7 movimientos de la cuenta
        IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return this.Movements.Take(pCount);
        }





    }
}
