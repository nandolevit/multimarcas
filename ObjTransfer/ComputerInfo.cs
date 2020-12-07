using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class ComputerInfo
    {
        public int compid { get; set; }
        public int compidunid { get; set; }
        public bool compativo { get; set; }
        public string comphostname { get; set; }
        public string compmac { get; set; }
        public string compadaptador { get; set; }
        public string compip { get; set; }
        public bool compserver { get; set; }
        public int compuser { get; set; }
    }
}
