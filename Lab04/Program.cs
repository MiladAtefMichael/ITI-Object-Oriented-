using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Lab4
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
            this.security_level = security_level;
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
            if (gender == "M" || gender == "F"||gender=="m"||gender=="f")
            {
                this.gender = gender;
            }
            else
            {
                this.gender = "try adjust value again";
            }
           
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
    struct HiringDate
    {
        private int day;
        private int month;
        private int year;
        public int  Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
    class Program
    {
        public static Employee[] concatEmployees(Employee[] employees_1, Employee[] employee_2)
        {
            int concatLength = employees_1.Length + employee_2.Length;
            Employee[] concatArr= new Employee[concatLength];
            int j = 0;
            for (int i=0;  i< concatLength; i++)
            {
                concatArr[i] = employees_1[i];
            }
            for (int i = employees_1.Length; i < concatLength; i++)
            {
                concatArr[i] = employees_1[j];
                j++;
            }
            return concatArr;
        }
        public static void DisplayData(Employee[] employee)
        {
            for(int i=0; i< employee.Length; i++)
            {
                employee[i].PrintEmployeeData();
            }
        }
        public static void Main(string[] args)
        {
            #region Task02
            HiringDate hiringDate_1=new HiringDate();
            Employee emp_1= new Employee();
            Console.Write("Enter Employee Id : ");
            emp_1.SetId(int.Parse(Console.ReadLine()));
            Console.Write("Enter Employee Name : ");
            emp_1.SetName(Console.ReadLine());
            Console.Write("Enter Employee Salary : ");
            emp_1.SetSalary(int.Parse(Console.ReadLine()));
            Console.Write("Enter Employee Gender : ");
            emp_1.SetGender(Console.ReadLine());
            Console.Write("Enter Employee security level (guest - developr - tester ): ");
            emp_1.SetSecurityLevel(Console.ReadLine());
            Console.WriteLine("Enter Employee Hiring Data :  ");
            Console.WriteLine("day :  ");
            hiringDate_1.Day=int.Parse(Console.ReadLine());
            Console.WriteLine("month :  ");
            hiringDate_1.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("year :  ");
            hiringDate_1.Year = int.Parse(Console.ReadLine());
            emp_1.SetHiringDate(hiringDate_1);
            Console.WriteLine("your Data saved successfully and yuor data is ------");
            emp_1.PrintEmployeeData();

            #endregion
            #region Task03

            Console.WriteLine();
            Console.Write("Enter number of Employees : ");
            int numOfEmployees=int.Parse(Console.ReadLine()) ;
            Employee[] empList=new Employee[numOfEmployees];
            HiringDate[] hiringDateList =new  HiringDate[numOfEmployees];
          
            for (int i = 0; i < numOfEmployees; i++)
            {
                Console.Write($"Enter Data of Employee of employee {i} ");
                bool idUnique = true;
                do
                {
                    Console.Write("Enter Employee Id : ");
                    int id = int.Parse(Console.ReadLine());

                    for (int j = i; j > 0; j--)
                    {
                        if (empList[j].GetId() == id)
                        {
                            idUnique = false;
                            Console.WriteLine("you use this id before please type another one");

                        }
                        else
                        {
                            empList[i].SetId(id);
                        }
                    }
                    
                } while (idUnique == false);
                Console.Write("Enter Employee Name : ");
                empList[i].SetName(Console.ReadLine());
                Console.Write("Enter Employee Salary : ");
                empList[i].SetSalary(int.Parse(Console.ReadLine()));
                Console.Write("Enter Employee Gender : ");
                empList[i].SetGender(Console.ReadLine());
                Console.Write("Enter Employee security level (guest - developr - tester ): ");
                empList[i].SetSecurityLevel(Console.ReadLine());
                Console.WriteLine("Enter Employee Hiring Data :  ");
                Console.WriteLine("day :  ");
                hiringDateList[i].Day = int.Parse(Console.ReadLine());
                Console.WriteLine("month :  ");
                hiringDateList[i].Month = int.Parse(Console.ReadLine());
                Console.WriteLine("year :  ");
                hiringDateList[i].Year = int.Parse(Console.ReadLine());
                empList[i].SetHiringDate(hiringDate_1);
            }
            DisplayData(empList);
            Console.ReadKey();
            #endregion
            
            #region Task 06
            char ch = 'a';
            int counter = 0;
            Employee[] staff=new Employee[10];
            HiringDate[] staffHiringDate=new HiringDate[10];
            do
            {
                Console.WriteLine("select your choice --\na-insert new employee\nb-display inserted employee only \nc-search by id\nd-search by name\ne-count number of inserted employee\nf-upadte employee by id \ng- delete employe by id");
                ch=char.Parse(Console.ReadLine());
                
                switch (ch)
                {
                    case 'a':
                        if (counter < 9) {
                            Console.WriteLine("enetr ");
                        Console.Write($"Enter Data of Employee of employee {counter+1} ");
                            bool idUnique = true;
                            do
                            {
                                Console.Write("Enter Employee Id : ");
                                int id_unique = int.Parse(Console.ReadLine());

                                for (int j = counter; j > 0; j--)
                                {
                                    if (staff[counter].GetId() == id_unique)
                                    {
                                        idUnique = false;
                                        Console.WriteLine("you use this id before please type another one");

                                    }
                                    else
                                    {
                                        staff[counter].SetId(id_unique);
                                    }
                                }

                            } while (idUnique == false);
                            Console.Write("Enter Employee Name : ");
                            staff[counter].SetName(Console.ReadLine());
                            Console.Write("Enter Employee Salary : ");
                            staff[counter].SetSalary(int.Parse(Console.ReadLine()));
                            Console.Write("Enter Employee Gender : ");
                            staff[counter].SetGender(Console.ReadLine());
                            Console.Write("Enter Employee security level (guest - developr - tester ): ");
                            staff[counter].SetSecurityLevel(Console.ReadLine());
                            Console.WriteLine("Enter Employee Hiring Data :  ");
                            Console.WriteLine("day :  ");
                            staffHiringDate[counter].Day = int.Parse(Console.ReadLine());
                            Console.WriteLine("month :  ");
                            staffHiringDate[counter].Month = int.Parse(Console.ReadLine());
                            Console.WriteLine("year :  ");
                            staffHiringDate[counter].Year = int.Parse(Console.ReadLine());
                            staff[counter].SetHiringDate(hiringDate_1);
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("you insert All Employees data ");
                        }
                        break;
                    case 'b':
                        DisplayData(staff);
                        break;
                    case 'c':
                        Console.Write("Enter Employee Id to search : ");
                        int id=int.Parse(Console.ReadLine());
                        for (int i = 0; i < staff.Length; i++)
                        {
                            if (staff[i].GetId() == id) staff[i].PrintEmployeeData();
                            else Console.WriteLine("id is not exist ");
                        }
                        break;
                    case 'd':
                        Console.Write("Enter Employee Id to search : ");
                        string name = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            if (staff[i].GetName() == name) staff[i].PrintEmployeeData();
                            else Console.WriteLine("id is not exist ");
                        }
                        break;
                    case 'e':
                        int insertedCount = 0;
                        for (int i = 0; i < staff.Length; i++)
                        {
                            if (staff[i].GetId() != 0) insertedCount++;
                            else Console.WriteLine($"number of inserted employess is {insertedCount}");
                        }
                        break;
                    case 'f':
                        Console.Write("enter id to update data : ");
                        int index = 0;
                        int upadte_id=int.Parse(Console.ReadLine());
                       
                        for (int i = 0; i < staff.Length; i++)
                        {
                            if (staff[i].GetId() == upadte_id) 
                            {
                                Console.Write("Enter Employee Name : ");
                                staff[i].SetName(Console.ReadLine());
                                Console.Write("Enter Employee Salary : ");
                                staff[i].SetSalary(int.Parse(Console.ReadLine()));
                                Console.Write("Enter Employee Gender : ");                                staff[i].SetGender(Console.ReadLine());
                                Console.Write("Enter Employee security level (guest - developr - tester ): ");
                                staff[i].SetSecurityLevel(Console.ReadLine());
                                Console.WriteLine("Enter Employee Hiring Data :  ");
                                Console.WriteLine("day :  ");
                                staffHiringDate[i].Day = int.Parse(Console.ReadLine());
                                Console.WriteLine("month :  ");
                                staffHiringDate[i].Month = int.Parse(Console.ReadLine());
                                Console.WriteLine("year :  ");
                                staffHiringDate[i].Year = int.Parse(Console.ReadLine());
                                staff[i].SetHiringDate(hiringDate_1);
                            }
                            else { Console.WriteLine("id is not exist "); }
                        }
                        break;
                    case 'g':
                        Console.Write("enter id to update data : ");
                        
                        int delete_id = int.Parse(Console.ReadLine());
                        
                        for (int i = 0; i < staff.Length; i++)
                        {
                            if (staff[i].GetId() == delete_id)
                            {
                                
                                staff[i].SetName(null);
                                staff[i].SetSalary(0);
                               
                                staff[i].SetGender(null);
                               
                                staff[i].SetSecurityLevel(null);
                                
                                
                                staffHiringDate[i].Day = 0;
                              
                                staffHiringDate[i].Month = 0;
                                
                                staffHiringDate[i].Year = 0;
                                staff[i].SetHiringDate(hiringDate_1);
                            }
                            else { Console.WriteLine("id is not exist "); }
                        }
                        break;

                }

            }while(ch!='e'||ch!='E');
            #endregion
            
        }
    }
}