using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class LoginConvertInfo
    {
        public string Login { get; set; }
        public byte[] Senha { get; set; }
    }
}
