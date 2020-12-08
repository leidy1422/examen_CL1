using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_EL1_BRANDON_SOTO_MALLQUI
{
    public class ClsElecktra:ClsProducto
    {
     
        public override double importePagar()
        {

            return cantidad * precioUnitario + CostoFlete();
        }
        public override double CostoFlete()
        {
            double flete = 0;
            switch (lineaProducto)
            {
                case "Audio Video":
                    flete = 30;
                    break;
                case "Blanca":
                    flete = 45;
                    break;
                case "Menaje":
                    flete = 40;
                    break;
            }
            return flete;

        }
    }
}
