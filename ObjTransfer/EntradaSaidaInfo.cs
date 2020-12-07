using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class EntradaSaidaInfo
    {
        public int entraid { get; set; }
        public DateTime entradatavenc { get; set; }
        public DateTime entradatalancamento { get; set; }
        public int entratipoidcat { get; set; }
        public string entratipocatdecricao { get; set; }
        public string entradocumento { get; set; }
        public decimal entravalor { get; set; }
        public decimal entravalorpago { get; set; }
        public int entranumparcela { get; set; }
        public int entracodtodasparcelas { get; set; }
        public int entranumtotalparcelas { get; set; }
        public string entraobs { get; set; }
        public bool entraconfirmada { get; set; }
        public int entraidfunc { get; set; }
        public int entraidtipoentrada { get; set; }
        public int entraidunidade { get; set; }
        public bool entraparcelado { get; set; }
        public int identradasaida { get; set; }
    }
}
