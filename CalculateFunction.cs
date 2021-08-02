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
    class GreaterThan50 : AverageCalculation, IScholarshipTypes_Premium
    {
        public void PremimumScholarShipProgram(int result)
        {
            int scholarship = 0;
            if (result > 100)
            {
                scholarship = 100000;
            }
           
            Console.WriteLine("\nscholarship is of {0}",scholarship);
        }
        public override int Calculatepercentage(SingleResponsibility marksInfo)
        {   

            int result = (marksInfo.maths + marksInfo.physics + marksInfo.chemistry) / 3;
            int bonus = 10;
            result = result + marksInfo.internalMarks + bonus;
            PremimumScholarShipProgram(result);
            return result;


        }
    }
}
