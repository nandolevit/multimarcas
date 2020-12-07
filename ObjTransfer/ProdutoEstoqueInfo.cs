using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ProdutoEstoqueInfo
    {
        public int prodestoqueid { get; set; }
        public decimal prodestoquequant { get; set; }
        public int prodestoqueidproduto { get; set; }
        public int prodestoqueidunidade { get; set; }
        public DateTime prodestoquedatacad { get; set; }
    }
}
