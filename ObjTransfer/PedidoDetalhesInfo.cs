using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class PedidoDetalhesInfo
    {
        public int peddetalhesid { get; set; }
        public int peddetalhesidprod { get; set; }
        public decimal peddetalhesquant { get; set; }
        public decimal peddetalhesvalorunit { get; set; }
        public decimal peddetalhesvalordesc { get; set; }
        public int peddetalhesidpedido { get; set; }
    }
}
