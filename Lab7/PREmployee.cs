using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class PREmployee : Employee
    {
        public sealed override void ShowEmployeeDetails()
        {
            Console.WriteLine($"Employee id : {Id} Name is {Name} and has salary : {Salary}");
        }
    }
}
