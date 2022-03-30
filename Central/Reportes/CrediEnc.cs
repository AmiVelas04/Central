using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Reportes
{
    class CrediEnc
    {
        public string Titulo { get; set; }
        public string fecha1 { get; set; }
        public string fecha2 { get; set; }
        public decimal TotalCred { get; set; }
        
        public List<CrediDet> Detalle = new List<CrediDet>();
        
    }
}
