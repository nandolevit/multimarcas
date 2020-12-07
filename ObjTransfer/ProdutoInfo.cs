using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ProdutoInfo : ProdutoEstoqueInfo
    {
        public int proId { get; set; }
        public string proDescricao { get; set; }
        public decimal proValorCompra { get; set; }
        public decimal proValorVarejo { get; set; }
        public decimal proValorAtacado { get; set; }
        public string proCodBarras { get; set; }
        public int proQuantMinima { get; set; }
        public bool proControleEstoque { get; set; }
        public int proidUser { get; set; }
        public DateTime proDataCad { get; set; }
        public string Desativado { get; set; }
        public int proidsubcategoria { get; set; }
        public int proidmarca { get; set; }
        public int proidfornecedor { get; set; }
        public int proidstatus { get; set; }
        public string procodkit { get; set; }
        public string prodetalhes { get; set; }
        public bool protaxa { get; set; }
    }
}
