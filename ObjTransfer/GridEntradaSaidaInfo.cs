using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridEntradaSaidaInfo
    {
        public int entralancamentoid { get; set; }
        public char strConfirmado { get; set; }
        public char strEntradaSaida { get; set; }
        public DateTime datapagamento { get; set; }
        public decimal valor { get; set; }
        public string parcelas { get; set; }
        public string categoria { get; set; }
        public string obs { get; set; }
        public int tipo { get; set; }
    }
}
