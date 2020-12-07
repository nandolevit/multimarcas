using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class PagamentoInfo
    {
        public int pagamentoid { get; set; }
        public int pagamentoidvenda { get; set; }
        public int pagamentoquantforma { get; set; }
        public decimal pagamentovalor { get; set; }
        public decimal pagamentotroco { get; set; }
    }
}
