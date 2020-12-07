using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ServicoInfo
    {
        public int serid { get; set; }
        public int seridcliente { get; set; }
        public int seridend { get; set; }
        public int serideletro { get; set; }
        public string serdescricao { get; set; }
        public decimal sertaxa { get; set; }
        public string serobs { get; set; }
        public DateTime serdataagend { get; set; }
        public int seridfunc { get; set; }
        public string sernomefunc { get; set; }
        public DateTime serdatacad { get; set; }
        public int seridunid { get; set; }
        public bool sergarantia { get; set; }
        public string sergarantiadescricao { get; set; }
        public int seridtipo { get; set; }
        public string sertipodescricao { get; set; }
        public int seridstatus { get; set; }
        public string serstatusdescricao { get; set; }
        public int seridtecresp { get; set; }
        public string serdefeitodescricao { get; set; }
        public bool servendaconfirm { get; set; }
        public DateTime serdatafinalizada { get; set; }
    }
}
