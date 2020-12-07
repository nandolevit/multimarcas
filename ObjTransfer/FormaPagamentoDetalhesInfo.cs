using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class FormaPagamentoDetalhesInfo
    {
        public int formdetalhesid { get; set; }
        public int formdetalhesidformpag { get; set; }
        public decimal formdetalhesvalor { get; set; }
        public string formdetalhesparcelas { get; set; }
    }
}
