using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class EnderecoInfo
    {
        public int IdEnd { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string PontoReferencia { get; set; }
        public int IdCliente { get; set; }
        public string endLogradouro { get; set; }
        public string endBairro { get; set; }
        public string endCidade { get; set; }
        public string endUf { get; set; }
        public bool endpadrao { get; set; }
    }
}
