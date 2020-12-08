using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace POOI_EL1_BRANDON_SOTO_MALLQUI
{
    public class ClsProducto

    {
        public int codCliente { get; set; }

        public string nomCliente { get; set; }

        public string nombreProducto { get; set; }

        public double precioUnitario { get; set; }

        public int cantidad { get; set; }

        public string lineaProducto { get; set; }

      

        public int contador;

        public ClsProducto()
        {

        }
        public string GeneraCodigo()
        {
            contador++;
            return "C" + contador.ToString("-0000");
        }

        // Metodo de importe a pagar costo del flete e imprte del a venta

        public  virtual double importePagar()
        {
            
            return cantidad * precioUnitario + CostoFlete();
        }
        public virtual double CostoFlete()
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

        public double importeVenta()
        {
            return cantidad * precioUnitario + CostoFlete();
        }

            
        public double Descuento()
        { 
            if (precioUnitario >= 500)
            return importePagar() * 0.07; 
            else
            return importePagar(); 
        }
        public double NETO()
        {
            return importePagar() - Descuento();
            }

        }
}

