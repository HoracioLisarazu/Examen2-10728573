using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg4Bss
    {
        Preg4Dal dal = new Preg4Dal();
        public DataTable PregBss4()
        {
            return dal.PregDal4();
        }
    }
}
