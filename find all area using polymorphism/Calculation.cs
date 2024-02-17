using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_all_area_using_polymorphism
{
    public class Calculation
    {
        public void area(int l) 
        {
            Console.WriteLine("The area of circle is:"+l*l);
        }

        public void area(int l,int w)
        {
            Console.WriteLine("The area of rectangle is:"+l*w);
        }

        public void area(float r)
        {
            float pi = 3.14f;
            Console.WriteLine(pi*r*r);
        }
    }
}
