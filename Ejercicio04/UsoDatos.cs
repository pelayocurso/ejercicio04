using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class UsoDatos
    {
        public String UsarDatos(Datos datos)
        {
            return datos.message + ": " + datos.numberOne + ", " + datos.numberTwo;
        }
    }
}
