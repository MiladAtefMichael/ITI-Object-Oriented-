using System;
using System.Diagnostics.Metrics;

namespace Lab05
{
    class Program
    {
       
        
        public static void DisplayDepartmentsNames(Department[] _departments)
        {
            Console.WriteLine("Deppartments is : --------");
            for (int i=0; i<_departments.Length; i++) 
            {
                Console.WriteLine(_departments[i].DepName);
            }

        }
        public static void DisplayDepartmentsEmpCount(Department[] _departments)
        {
            Console.WriteLine("number of employees in Deppartments is : --------");
            for (int i = 0; i < _departments.Length; i++)
            {
                Console.WriteLine($"there is {_departments[i].Staff.Length} Employee in Department {_departments[i].DepName}");
            }

        }
        public static void DisplayCompanyEmpCount(Company _company)
        {
            int counter = 0;
            Console.Write("number of employees in company is : ");
            for (int i = 0; i < _company.Departments.Length; i++)
            {
                counter += _company.Departments[i].Staff.Length;
            }
            Console.WriteLine(counter);

        }
        public static void SearchEmployeeByIdInDepartment(Department[] _department, int _id, string _depName)
        {
            for(int i = 0; i < _department.Length; i++)
            {
                if (_department[i].DepName== _depName)
                {
                    for(int j = 0; j < _department[i].Staff.Length;j++)
                    {
                        if (_department[i].Staff[j].GetId()== _id)
                        {
                            _department[i].Staff[j].PrintEmployeeData();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Can not found Employee with this id ");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Can not found Department  with this name ");
                }
            }
        }
        public static void updateEmployeeNameInDepartment(Department[] _department,int _id,  string _depName,String newName)
        {
            for (int i = 0; i < _department.Length; i++)
            {
                if (_department[i].DepName == _depName)
                {
                    for (int j = 0; j < _department[i].Staff.Length; j++)
                    {
                        if (_department[i].Staff[j].GetId() == _id)
                        {
                            _department[i].Staff[j].SetName(newName);
                            Console.WriteLine("Data After Update -------");
                            _department[i].Staff[j].PrintEmployeeData();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Can not found Employee with this id ");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Can not found Department  with this name ");
                }
            }
        }
        public static void DeleteEmployeeByIdInDepartment(Department[] _department, int _id, string _depName)
        {
            for (int i = 0; i < _department.Length; i++)
            {
                if (_department[i].DepName == _depName)
                {
                    for (int j = 0; j < _department[i].Staff.Length; j++)
                    {
                        if (_department[i].Staff[j].GetId() == _id)
                        {
                            _department[i].Staff[j]=new Employee();
                            Console.WriteLine("Employee Deleted Successfully ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Can not found Employee with this id ");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Can not found Department  with this name ");
                }
            }
        }
        public static Department[] FillDaepartmentsData(int numOfDep)
        {
            Department[] departments= new Department[numOfDep];
            for (int i=0;i<numOfDep;i++)
            {
                Console.Write($"Enter the Name of Deppartment {i + 1} :");
                departments[i].DepName = Console.ReadLine();
                Console.Write($"Enter Manager Name of Deppartment {i + 1} :");
                departments[i].Manager = Console.ReadLine();
                Console.Write($"Enter the Number of Employees in Deppartment {departments[i].DepName} :");
                int numOfEmp = int.Parse(Console.ReadLine());
                Employee[] employees= new Employee[numOfEmp];
                HiringDate[] hiringDates=new HiringDate[numOfEmp];
                for (int j=0;j<numOfEmp;j++)
                {
                    Console.Write("Enter Employee Id : ");
                    int idUnique = int.Parse(Console.ReadLine());
                    if (checkUnique(idUnique, employees[i])) employees[j].Employee[idUnique];
                    Console.Write("Enter Employee Name : ");
                    employees[j].SetName(Console.ReadLine());
                    Console.Write("Enter Employee Salary : ");
                    employees[j].SetSalary(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Employee Gender : ");
                    employees[j].SetGender(Console.ReadLine());
                    Console.Write("Enter Employee security level (guest - developr - tester ): ");
                    employees[j].SetSecurityLevel(Console.ReadLine());
                    Console.WriteLine("Enter Employee Hiring Data :  ");
                    Console.WriteLine("day :  ");
                    hiringDates[j].Day = int.Parse(Console.ReadLine());
                    Console.WriteLine("month :  ");
                    hiringDates[j].Month = int.Parse(Console.ReadLine());
                    Console.WriteLine("year :  ");
                    hiringDates[j].Year = int.Parse(Console.ReadLine());
                    employees[j].SetHiringDate(hiringDates[j]);
                }
                departments[i].Staff = employees;
            }
            return departments;
        }
        public static bool checkUnique(int _id,Employee _employee)
        {
            bool idUnique = true;
            do
            {
                

                    if (_employee.GetId() == _id)
                    {
                        idUnique = false;
                        Console.WriteLine("you use this id before please type another one");
                }

            } while (idUnique == false);
            return idUnique;
        }
        
        



        public static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter the Number of Departments : ");
            int numOfDep = int.Parse(Console.ReadLine());
            Department[] departments = new Department[numOfDep];
            departments = FillDaepartmentsData(numOfDep);
            Company company = new Company() { CompanyName = "el zizo", Departments = departments };

            do
            {
               
                Console.WriteLine("select option ___ \na-Diplay all Departemnt names\nb-Display depatments count per department\nc-Diplay total number of employees in company\nd-search for employee id in department\ne-updae employee namev in department\nf- delete employee by id \ng-exit");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case'a':
                        DisplayDepartmentsNames(departments);
                        Console.ReadKey();
                        break;
                    case 'b':
                        DisplayDepartmentsEmpCount(departments);
                        Console.ReadKey();
                        break;
                    case 'c':
                        DisplayCompanyEmpCount(company);
                        Console.ReadKey();
                        break;
                    case 'd':
                        Console.Write("Enter Department name : ");
                        String name=Console.ReadLine();
                        Console.Write("Enter Employee id  : ");
                        int id = int.Parse(Console.ReadLine());
                        SearchEmployeeByIdInDepartment(departments,id,name);
                        Console.ReadKey();
                        break;
                    case 'e':
                        Console.Write("Enter Department name : ");
                        String updatename = Console.ReadLine();
                        Console.Write("Enter Employee id  : ");
                        int updateid = int.Parse(Console.ReadLine());
                        Console.Write("Enter new name : ");
                        String newname = Console.ReadLine();
                        updateEmployeeNameInDepartment(departments,updateid, updatename,newname);
                        Console.ReadKey();
                        break;
                    case 'f':
                        Console.Write("Enter Department name : ");
                        String deletename = Console.ReadLine();
                        Console.Write("Enter Employee id  : ");
                        int deleteid = int.Parse(Console.ReadLine());
                        DeleteEmployeeByIdInDepartment(departments, deleteid, deletename);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("you select wrong option please try again ..");
                        break;
                }

            }while(ch != 'g');
            Console.ReadKey();
        }
    }
}