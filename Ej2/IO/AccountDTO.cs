﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.IO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double OverDraftLimit { get; set; }
        public double Balance { get; set; }
    }
}
