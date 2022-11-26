using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class HREmployee : Employee
    {
        public sealed override void ShowEmployeeDetails()
        {
            Console.WriteLine($"Employee id : {Id} Name is {Name} and has salary : {Salary}");
        }
        public static HREmployee operator +(HREmployee one,HREmployee two)
        {
            HREmployee hREmployee= new HREmployee();
             
            hREmployee.Clients= new Client[one.Clients.Length + two.Clients.Length];
            for (int i=0;i<one.Clients.Length;i++)
            {
                hREmployee.Clients[i] = one.Clients[i];
            }
            int count = 0;
            for (int i = one.Clients.Length; i < hREmployee.Clients.Length; i++)
            {
                
                
                hREmployee.Clients[i] = two.Clients[count];
                count++;
            }
            return hREmployee;
        }
        public static bool operator >(HREmployee one, HREmployee two)
        {
            if (one.Clients.Length > two.Clients.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator <(HREmployee one, HREmployee two)
        {
            if (one.Clients.Length < two.Clients.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(HREmployee one, HREmployee two)
        {
            if (one.Clients.Length > two.Clients.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator <=(HREmployee one, HREmployee two)
        {
            if (one.Clients.Length < two.Clients.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
