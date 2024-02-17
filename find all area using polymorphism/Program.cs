using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_all_area_using_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            calculation.area(2, 2);
            calculation.area(4);
            calculation.area(3f);
            Console.ReadKey();
        }
    }
}
