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

        public Client iCliente { get; set; }

        public List<AccountMovement> iMovements { get; set; }

        //Obtiene el balance de la cuenta
        public double GetBalance()
        {
            double iBalance = 0;
            foreach (AccountMovement item in iMovements)
            {
                iBalance += item.Amount;
            }
            return iBalance;
        }

        //Obtiene los ultimos 7 movimientos
        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            AccountMovement[] iUltimosMov = new AccountMovement[pCount];        //Crea un array auxiliar
            iMovements.OrderBy(x => x.Date);                                    //Ordena la lista por fecha
            for (int i=0; i<pCount-1; i++)
            {
                iUltimosMov[i] = iMovements[i];                                 //Ingresa los primeros 7 elementos en el array
            }
            
            return iUltimosMov;
        }

        



    }
}
