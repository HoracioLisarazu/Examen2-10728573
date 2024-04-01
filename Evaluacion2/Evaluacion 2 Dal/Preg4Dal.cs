using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg4Dal
    {
        public DataTable PregDal4()
        {
            string consulta = "SELECT        IDPRODUCTO, NOMBRE, UNIDAD, ESTADO\r\nFROM            PRODUCTO";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
