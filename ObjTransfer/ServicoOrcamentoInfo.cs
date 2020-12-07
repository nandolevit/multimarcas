using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ServicoOrcamentoInfo
    {
        public int servicoorcamentoid { get; set; }
        public int servicoorcamentoidserv { get; set; }
        public int servicoorcamentoidprod { get; set; }
        public decimal servicoorcamentoquant { get; set; }
        public decimal servicoorcamentovalorunit { get; set; }
        public decimal servicoorcamentovalordesc { get; set; }
        public bool servicoorcamentotaxaativo { get; set; }
    }
}
