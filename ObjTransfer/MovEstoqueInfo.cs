using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class MovEstoqueInfo
    {
        public int movestoqueid { get; set; }
        public int movestoqueidtipomovimento { get; set; }
        public int movestoqueidproduto { get; set; }
        public decimal movestoquequant { get; set; }
        public decimal movestoquevalor { get; set; }
    }
}
