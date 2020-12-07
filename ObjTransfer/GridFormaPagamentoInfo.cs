using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridFormaPagamentoInfo
    {
        public int pagid { get; set; }
        public int pagband { get; set; }
        public int pagtipo { get; set; }
        public decimal pagvalor { get; set; }
        public string pagdescricao { get; set; }
        public string pagbanddescricao { get; set; }
        public int parc{ get; set; }
        public string parcela { get; set; }
    }
}
