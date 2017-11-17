using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.Domain
{
    class Account
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public virtual Client Cliente { get; set; }

        public virtual IList<AccountMovement> Movements { get; set; }

        

        /// <summary>
        /// Obtiene el balance de la cuenta
        /// </summary>
        /// <returns>Balance de la cuenta</returns>
        public double GetBalance()
        {
            return this.Movements.Sum(t => t.Amount);
        }

        /// <summary>
        /// Obtención de los n movimientos de la cuenta
        /// </summary>
        /// <param name="pCount">Cantidad de movimientos</param>
        /// <returns>Movimiento de la cuenta</returns>
        IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return this.Movements.Take(pCount);
        }





    }
}
