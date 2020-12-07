using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class PedidoInfo
    {
        public int pedidoid { get; set; }
        public string pedidocod { get; set; }
        public int pedidoidfunc { get; set; }
        public int pedidoidunid { get; set; }
        public int pedidoidserv { get; set; }
        public DateTime pedidodata { get; set; }
        public int pedidoidstatus { get; set; }
        public decimal pedidototalvalor { get; set; }
        public int pedidototalitem { get; set; }
        public string status { get; set; }
    }
}
