using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjTransfer
{
    public class CaixaAbrirInfo
    {
        public int caixaabririd { get; set; }
        public DateTime caixaabrirdata { get; set; }
        public decimal caixaabrirvalor { get; set; }
        public int caixaabriridfunc { get; set; }
        public bool caixaabrirfechado { get; set; }
        public int caixaabriridunidade { get; set; }
        public DateTime caixafechardata { get; set; }
        public decimal caixafecharvalorcartaocredito { get; set; }
        public decimal caixafecharvalorcartaodebito { get; set; }
        public decimal caixafecharvalordinheiro { get; set; }
        public decimal caixafecharvalorcheque { get; set; }
        public decimal caixafecharvalorcarne { get; set; }
        public decimal caixafecharvalordeposito { get; set; }
        public int caixafecharidfunc { get; set; }
        public decimal caixafecharvalortotal { get; set; }
        public decimal caixafecharvalorrecebimentos { get; set; }
        public decimal caixafecharvalorpagamentos { get; set; }
        public decimal caixafecharvalorsangria { get; set; }
        public decimal caixafecharvalorsaldoespecie { get; set; }
    }
}
