using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Reportes
{
    class FacturaEnc
    {
       public string fecha { set; get; }
        public string hora { set; get; }
        public int ticket { set; get; }
       public string cajero {set;get;}
       public string total { set; get; }
        public string efectivo { set; get; }
        public string cambio { set; get; }
        public string descu { get; set; }
        public string cliente { get; set; }

        public List<FacturaDet> Detall = new List<FacturaDet>();

    }
}
