using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Domain
{
    //Movimientos de la cuenta
    public class AccountMovement
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public double Amount { get; set; }
    }
}
