using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Reportes
{
    class DiarioDet
    {
        public int orden { get; set; }
        public int venta { get; set; }
        public string codigo { get; set; }
        public string producto { get; set; }
        public string desc { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }
        public string marca { get; set; }
       
    }
}
