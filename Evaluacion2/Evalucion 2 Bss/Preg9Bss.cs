using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg9Bss
    {
        Preg9Dal dal = new Preg9Dal();
        public DataTable PregBss9()
        {
            return dal.PregDal9();
        }
    }
}
