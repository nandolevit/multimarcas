using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridViewVendaPeriodo
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Debito { get; set; }
        public decimal Credito { get; set; }
        public decimal Cheque { get; set; }
        public decimal Deposito { get; set; }
        public decimal Outras { get; set; }
        public decimal Total { get; set; }
        public int Turno { get; set; }
        public string Cancel { get; set; }
    }
}
