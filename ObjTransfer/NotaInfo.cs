using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class NotaInfo
    {
        public int notId { get; set; }
        public int notIdCliente { get; set; }
        public int notIdAutorizada { get; set; }
        public int notIdloja { get; set; }
        public int notideletro { get; set; }
        public string notNome { get; set; }
        public string notNumSerie { get; set; }
        public DateTime notEmissao { get; set; }
        public string notObs { get; set; }
        public int notIdFunc { get; set; }
        public string notNum { get; set; }
        public string notVencimento { get; set; }
    }
}
