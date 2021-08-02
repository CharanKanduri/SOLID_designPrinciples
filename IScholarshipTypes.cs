using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_design_principles
{   //Interface Segregation Principle
    public  interface IScholarshipTypes_Premium
    {
        public void PremimumScholarShipProgram(int result);
    }
   public interface FeeDeduction
    {
        public int AlterFee();
    }

}
