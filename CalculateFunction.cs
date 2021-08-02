using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_design_principles
{
    public class LesserThan50 : AverageCalculation
    {
        public override int Calculatepercentage(SingleResponsibility marksInfo)
        {
            int result = (marksInfo.maths + marksInfo.physics + marksInfo.chemistry) / 3;
            return result+marksInfo.internalMarks;
        }
    }
    class GreaterThan50 : AverageCalculation
    {
        public override int Calculatepercentage(SingleResponsibility marksInfo)
        {
            int result = (marksInfo.maths + marksInfo.physics + marksInfo.chemistry) / 3;
            int bonus = 10;
            return result +marksInfo.internalMarks +bonus ;
        }
    }
}
