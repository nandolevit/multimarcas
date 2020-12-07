using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class UserInfo
    {
        public int useid { get; set; }
        public string uselogin { get; set; }
        public string usesenha { get; set; }
        public int useativo { get; set; }
        public int useidfuncionario { get; set; }
        public int usenovologin { get; set; }
        public string usenome { get; set; }
        public int loginid { get; set; }
    }
}
