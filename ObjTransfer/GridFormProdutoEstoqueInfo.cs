using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridFormProdutoEstoqueInfo
    {
        public int proid { get; set; }
        public string prodescricao { get; set; }
        public decimal provalorcompra { get; set; }
        public decimal provalorvarejo { get; set; }
        public decimal provaloratacado { get; set; }
        public string procodbarras { get; set; }
        public int proquantminima { get; set; }
        public int proidsubcategoria { get; set; }
        public string prodsubcatnome { get; set; }
        public string prodcatnome { get; set; }
        public int proidmarca { get; set; }
        public string autnome { get; set; }
        public int proidfornecedor { get; set; }
        public string fornome { get; set; }
        public decimal prodestoquequant { get; set; }
        public int prodestoqueid { get; set; }
    }
}
