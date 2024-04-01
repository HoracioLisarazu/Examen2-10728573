using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg7Bss
    {
        Preg7Dal dal = new Preg7Dal();
        public DataTable PregBss7()
        {
            return dal.PregDal7();
        }
    }
}
