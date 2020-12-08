using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EL1_BRANDON_SOTO_MALLQUI
{
    public class Alumno
    {
        public string codigo { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string grado { get; set; }
        public string correo { get; set; }
        //variable estatica para generar un contador
        public static int contador;
        //metodo
        public string GeneraCodigo()
        {
            contador++;
            return "ALU" + contador.ToString("0000");
        }
    }
}
