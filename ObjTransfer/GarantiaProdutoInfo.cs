using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class GarantiaProdutoInfo
    {
        public int Loja { get; set; }
        public int Autorizada { get; set; }
        public string NotaF { get; set; }
        public string NotaSerie { get; set; }
        public DateTime Emissao { get; set; }
        public string Nome { get; set; }
        public int CodCliente { get; set; }
        public string Obs { get; set; }
    }
}
