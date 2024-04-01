using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg6Bss
    {
        Preg6Dal dal = new Preg6Dal();
        public DataTable PregBss6()
        {
            return dal.PregDal6();
        }
    }
}
