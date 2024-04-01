
using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Evalucion_2_Bss
{
    
    public class Preg1Bss
    {
        Preg1Dal dal = new Preg1Dal();
        public DataTable PregBss1()
        {
            return dal.PregDal1();
        }
    }
}
