using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GridViewComissaoInfo
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataVenda { get; set; }
        public string DescricaoProduto { get; set; }
        public string CategoriaSub { get; set; }
        public string Marca { get; set; }
        public decimal Quant { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal Valor { get; set; }
    }
}
