using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class EntradaSaidaPesquisar
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string Confirmado { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public int Unidade { get; set; }
    }
}
