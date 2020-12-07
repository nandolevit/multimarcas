using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class VFormaPagPorVendaInfo
    {
        public int pagamentoid { get; set; }
        public int pagamentoidvenda { get; set; }
        public int pagdetalhesnumparcelas { get; set; }
        public decimal pagdetalhesvalor { get; set; }
        public int formpagid { get; set; }
        public string formpagdescricao { get; set; }
    }
}
