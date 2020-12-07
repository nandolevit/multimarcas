using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class EmpresaInfo
    {
        public string empcnpj { get; set; }
        public string emprazaosocial { get; set; }
        public string empfantasia { get; set; }
        public string empemail { get; set; }
        public string emptelefone { get; set; }
        public string empsite { get; set; }
        public string empcomplemento { get; set; }
        public string empreferencia { get; set; }
        public string empcep { get; set; }
        public string emplogradouro { get; set; }
        public string empbairro { get; set; }
        public string empcidade { get; set; }
        public string empuf { get; set; }
        public string empcod { get; set; }
        public DateTime empfundada { get; set; }
        public DateTime empdatacad { get; set; }
        public string empconexao { get; set; }
        public int empativada { get; set; }
        public DateTime empdataativo { get; set; }
        public string empobs { get; set; }
    }
}
