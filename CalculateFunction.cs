using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_design_principles
{
    class CalculateFunction
    {
        public static int Calculatepercentage(int m, int p, int c)
        {
            int result = (m + p + c) / 3;
            return result;

        }


    }
}
