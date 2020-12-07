using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridPedidoInfo
    {
        public int cod { get; set; }
        public string descricao { get; set; }
        public decimal quant { get; set; }
        public decimal valorUnit { get; set; }
        public decimal valorDesc { get; set; }
        public decimal valorTotal { get; set; }
    }
}
