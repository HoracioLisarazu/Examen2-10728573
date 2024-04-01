using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg3Bss
    {
        Preg3Dal dal = new Preg3Dal();
        public DataTable PregBss3()
        {
            return dal.PregDal3();
        }
    }
}
