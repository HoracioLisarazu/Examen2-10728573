﻿using Evaluacion_2_Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucion_2_Bss
{
    public class Preg10Bss
    {
        Preg10Dal dal = new Preg10Dal();
        public DataTable PregBss10()
        {
            return dal.PregDal10();
        }
    }
}
