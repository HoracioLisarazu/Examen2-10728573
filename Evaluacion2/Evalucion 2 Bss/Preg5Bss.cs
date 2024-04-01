using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg5Bss
    {
        Preg5Dal dal = new Preg5Dal();
        public DataTable PregBss5()
        {
            return dal.PregDal5();
        }
    }
}
