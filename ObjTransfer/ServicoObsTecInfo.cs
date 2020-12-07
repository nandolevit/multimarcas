using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ServicoObsTecInfo
    {
        public int IdObs { get; set; }
        public int IdFunc { get; set; }
        public string ObsTec { get; set; }
        public DateTime ControleTemp { get; set; }
        public int IdOs { get; set; }
        public string NomeFunc { get; set; }
    }
}
