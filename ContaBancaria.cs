using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class ContaBancaria
    {
        public string agencia { get; set; }
        public string numeroConta { get; set; }
        public decimal saldo { get; private set; }

    }
}
