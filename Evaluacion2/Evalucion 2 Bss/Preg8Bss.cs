using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg8Bss
    {
        Preg8Dal dal = new Preg8Dal();
        public DataTable PregBss8()
        {
            return dal.PregDal8();
        }
    }
}
