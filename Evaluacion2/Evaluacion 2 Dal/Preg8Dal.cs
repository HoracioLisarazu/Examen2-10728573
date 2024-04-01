using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg8Dal
    {
        public DataTable PregDal8()
        {
            string consulta = "SELECT        PROVEEDOR.NOMBRE, PRODUCTO.UNIDAD\r\nFROM            PROVEEDOR INNER JOIN\r\n                         PROVEE ON PROVEEDOR.IDPROVEEDOR = PROVEE.IDPROVEEDOR INNER JOIN\r\n                         PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO\r\nWHERE PRODUCTO.UNIDAD = (SELECT TOP 1 MAX(UNIDAD) FROM PROVEEDOR INNER JOIN\r\n                         PROVEE ON PROVEEDOR.IDPROVEEDOR = PROVEE.IDPROVEEDOR INNER JOIN\r\n                         PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO)";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
