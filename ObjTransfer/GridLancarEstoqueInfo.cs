using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class GridLancarEstoqueInfo
    {
        public int id { get; set; }
        public int idproduto { get; set; }
        public string descricao { get; set; }
        public decimal valorUnit { get; set; }
        public decimal valorTotal { get; set; }
        public decimal quant { get; set; }
        public int idestoque { get; set; }
    }
}
