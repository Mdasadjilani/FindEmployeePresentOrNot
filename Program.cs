using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-1 Find Employee is present or not
            int empPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empPresent==empCheck)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadLine();
        }
    }
}
