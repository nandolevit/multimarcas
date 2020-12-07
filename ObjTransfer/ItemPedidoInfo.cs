using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ItemPedidoInfo
    {
        public int iteId { get; set; }
        public int iteFkPedido { get; set; }
        public int iteFkProduto { get; set; }
        public int iteQuant { get; set; }
        public decimal iteValorUnitario { get; set; }
        public decimal iteValorDesconto { get; set; }
        public decimal iteValorTotal { get; set; }
        public string proDescricao { get; set; }
    }
}
