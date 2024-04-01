using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2_Dal
{
    
    public class Preg1Dal
    {
        public DataTable PregDal1()
        {
            string consulta = "SELECT        PERSONA.NOMBRE, PERSONA.APELLIDO, CLIENTE.IDCLIENTE\r\nFROM            CLIENTE INNER JOIN\r\n                         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "sddsf");
        }
    }
}
