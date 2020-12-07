using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class CaixaTurnoInfo
    {
        public int caixaturnoid { get; set; }
        public DateTime caixaturnodata { get; set; }
        public DateTime caixaturnodatafechamento { get; set; }
        public decimal caixaturnovalorcartaocredito { get; set; }
        public decimal caixaturnovalorcartaodebito { get; set; }
        public decimal caixaturnovalordinheiro { get; set; }
        public decimal caixaturnovalorcheque { get; set; }
        public decimal caixaturnovalorcarne { get; set; }
        public decimal caixaturnovalordeposito { get; set; }
        public int caixaturnoidfuncabrir { get; set; }
        public int caixaturnoidabrir { get; set; }
        public decimal caixaturnovalortotal { get; set; }
        public decimal caixaturnovalorrecebimentos { get; set; }
        public decimal caixaturnovalorpagamentos { get; set; }
        public decimal caixaturnovalorsangria { get; set; }
        public decimal caixaturnovalorsaldoespecie { get; set; }
        public int caixaturnonum { get; set; }
        public bool caixaturnofechado { get; set; }
        public decimal caixaturnovalorabrir { get; set; }
        public int caixaturnoidfuncfechar { get; set; }
    }
}
