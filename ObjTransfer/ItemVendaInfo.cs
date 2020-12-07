using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class ItemVendaInfo
    {
        public int Id { get; set; }
        public string Barras { get; set; }
        public string Descricao { get; set; }
        public decimal Quant { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorDesc { get; set; }
        public decimal Total { get; set; }
        public int funid { get; set; }
        public string  funnome { get; set; }
    }
}
