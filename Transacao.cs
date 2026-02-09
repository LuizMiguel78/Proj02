using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Transacao
    {
        public ContaBancaria contaOrigem { get; set; }
        public ContaBancaria contaDestino { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; } 
    }
}
