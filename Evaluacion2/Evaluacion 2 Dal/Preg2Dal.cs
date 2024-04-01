using DAL;
using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg2Dal
    {
        public DataTable PregDal2()
        {
            string consulta = "SELECT        PROVEEDOR.NOMBRE, INGRESO.TOTAL\r\nFROM            PROVEEDOR INNER JOIN\r\n                         INGRESO ON PROVEEDOR.IDPROVEEDOR = INGRESO.IDPROVEEDOR";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
