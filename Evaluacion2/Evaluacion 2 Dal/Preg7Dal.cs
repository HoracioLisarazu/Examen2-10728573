using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    public class Preg7Dal
    {
        public DataTable PregDal7()
        {
            string consulta = "SELECT        CLIENTE.IDCLIENTE, PERSONA.NOMBRE, PERSONA.APELLIDO, INGRESO.TOTAL\r\nFROM            PRODUCTO INNER JOIN\r\n                         DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO INNER JOIN\r\n                         DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO INNER JOIN\r\n                         VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\r\n                         CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE INNER JOIN\r\n                         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA INNER JOIN\r\n                         INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
