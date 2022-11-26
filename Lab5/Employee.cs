using System;
namespace Lab05
{
    struct Employee
    {
        int id;
        private string name;
        private string security_level;
        private int salary;
        private string gender;
        HiringDate hiring_date;
        public int GetId() { return id; }
        public int this[int _id ]
        {
            get {return id; }
            set {id= _id;  }
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public String GetSecurityLevel()
        {
            return this.security_level;
        }
        public void SetSecurityLevel(string security_level)
        {
            bool chooseOption=false;
            do
            {
                if (security_level == "developer" || security_level == "guest" || security_level == "tester")
                {
                    this.security_level = security_level;
                    chooseOption = true;
                }
                else
                {
                    Console.WriteLine("try adjust value again");
                }
            } while (chooseOption == false);
            
        }
        public int GetSalary()
        {
            return this.salary;
        }
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public void SetGender(string gender)
        {
            bool chooseOption = false;
            do
            {
                if (gender == "M" || gender == "F" || gender == "m" || gender == "f")
                {
                    this.gender = gender;
                    chooseOption = true;
                }
                else
                {
                   Console.WriteLine( "try adjust value again");
                }
            }while(chooseOption == false);

        }
        public HiringDate GetHiringDate()
        {
            return this.hiring_date;
        }
        public void SetHiringDate(HiringDate hiring_date)
        {
            this.hiring_date = hiring_date;
        }
        public void PrintEmployeeData()
        {
            Console.WriteLine($"Employee Id : {id}\nEmployee name : {name}\nEmployee Salary : {salary}\nEmployee Security Level : {security_level}\nEmployee Hiring Date : day {hiring_date.Day} Month : {hiring_date.Month} Year : {hiring_date.Year}");
        }
    }
}