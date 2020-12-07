using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ChatOnlineInfo
    {
        public int chatid { get; set; }
        public int chatidenvio { get; set; }
        public int chatidrecebe { get; set; }
        public string chatmessage { get; set; }
        public DateTime chatdata { get; set; }
        public bool chatlida { get; set; }
        public string chatident { get; set; }
    }
}
