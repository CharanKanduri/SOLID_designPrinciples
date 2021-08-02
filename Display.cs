using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_design_principles
{
    class Display
    {
        public void ShowInfo()
        {
            List<SingleResponsibility> marksInfo = SingleResponsibility.GetInput();
          
            foreach (var i in marksInfo)
            {
                Console.WriteLine("\nmarks in maths " + i.maths);
                Console.WriteLine("\nmarks in chemistry " + i.chemistry);
                Console.WriteLine("\nmarks in physics " + i.physics);
                Console.WriteLine("\n*****Internal marks ****");
                Console.WriteLine("\n{0}",i.internalMarks);
                if (i.internalMarks > 50)
                {   //Replace with abstract class LSP
                    AverageCalculation greaterThan50 = new GreaterThan50();
                    int percentage = greaterThan50.Calculatepercentage(i);
                    Console.WriteLine("total average is: " + percentage);
                }
                else {
                    AverageCalculation lesserThan50 = new LesserThan50();
                    int percentage = lesserThan50.Calculatepercentage(i);
                    Console.WriteLine("total average is: " + percentage);
                }
            }

        }
    }
}
