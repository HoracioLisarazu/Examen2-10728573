using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg6Dal
    {
        public DataTable PregDal6()
        {
            string consulta = "";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
