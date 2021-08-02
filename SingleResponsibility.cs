using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_design_principles
{
    class SingleResponsibility
    {
        public static List<SingleResponsibility> list = new List<SingleResponsibility>();
        public int maths { get; set; }
        public int chemistry { get; set; }
        public int physics { get; set; }
        
        public SingleResponsibility(int maths, int chemistry, int physics)
        {
            this.maths = maths;
            this.chemistry = chemistry;
            this.physics = physics;
        }   
        public static List<SingleResponsibility> GetInput()
        {
                //Employee Salary Computation
                Console.WriteLine("\nEnter maths marks:");
                int maths = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter physics marks:");
                int physics = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the chemistry marks");
                int chemistry = Convert.ToInt32(Console.ReadLine());

            SingleResponsibility singleResponsibility = new SingleResponsibility(maths, chemistry, physics);
            list.Add(singleResponsibility);

            return list;
        }
    }
}
