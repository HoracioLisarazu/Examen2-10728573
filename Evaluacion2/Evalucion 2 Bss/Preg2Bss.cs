using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg2Bss
    {
        Preg2Dal dal = new Preg2Dal();
        public DataTable PregBss2()
        {
            return dal.PregDal2();
        }
    }
}
