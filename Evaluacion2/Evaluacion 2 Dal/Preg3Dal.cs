using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg3Dal
    {
        public DataTable PregDal3()
        {
            string consulta = "SELECT  TOP 1    MARCA.NOMBRE, SUM(PRODUCTO.UNIDAD) AS CANTIDAD\r\nFROM            MARCA INNER JOIN\r\n                         PRODUCTO ON MARCA.IDMARCA = PRODUCTO.IDMARCA INNER JOIN\r\n                         DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO INNER JOIN\r\n                         VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA\r\nGROUP BY MARCA.NOMBRE\r\nORDER BY CANTIDAD DESC";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
