using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridClientePedidoInfo
    {
        public int id { get; set; }
        public string cod { get; set; }
        public string func { get; set; }
        public int quant { get; set; }
        public decimal valorTotal { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; }
    }
}
