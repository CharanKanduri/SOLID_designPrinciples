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
            List<SingleResponsibility> employeeDetails = SingleResponsibility.GetInput();
          
            foreach (var i in employeeDetails)
            {
                Console.WriteLine("\nmarks in maths " + i.maths);
                Console.WriteLine("marks in chemistry " + i.chemistry);
                Console.WriteLine("marks in physics " + i.physics);

                int percentage = CalculateFunction.Calculatepercentage(i.maths, i.physics, i.chemistry);
                Console.WriteLine("total average is: " + percentage);
            }

        }
    }
}
