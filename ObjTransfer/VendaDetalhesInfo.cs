using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class VendaDetalhesInfo
    {
        public int vendetalhesid { get; set; }
        public int vendetalhesidvenda { get; set; }
        public int vendetalhesidprod { get; set; }
        public decimal vendetalhesquant { get; set; }
        public decimal vendetalhesvalorunit { get; set; }
        public decimal vendetalhesvalordesc { get; set; }
        public int vendetalhesidfunc { get; set; }
    }
}
