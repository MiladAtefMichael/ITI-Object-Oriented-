using System;
using System.IO.Pipes;

namespace Lab7
{
    class Program
    {
        public static void printEmployeesDetails(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].ShowEmployeeDetails();
                for (int j = 0; j < employees[i].Clients.Length; j++)
                {
                    employees[i].Clients[j].ShowClientDetaila();
                }
            }
        }
        public static void Main(string[] args)
        {
            #region Task01
            Duration D1 = new Duration(6000);
            Duration D2 = new Duration(90,80);
            Duration D3 = new Duration(70,80,90);
            D1.print();
            D2.print();
            D3.print();
            D3=D1+D2;
            D3.print();
            D3 = D1 + 7800;
            D3.print();
            if(D3 >D1)
            {
                Console.WriteLine("the first duration longer than second duration ");
            }
            else
            {
                Console.WriteLine("the second duration longer than first duration ");
            }
            if (D3 < D1)
            {
                Console.WriteLine("the second duration longer than first duration ");
                
            }
            else
            {
                Console.WriteLine("the first duration longer than second duration ");

            }
          
            #endregion
            #region task 02
            Employee[] employees=new Employee[]
            {
               new HREmployee(){Id = 5,Name = "zizo",Salary=2000,
               Clients=new Client[]
               {
                   new Client(){Name="Ahmed",Id=6,City="Mansoura" },
                   new Client(){Name="Mohamed",Id=7,City="mahalla"},
                   new Client(){Name="Ahmed",Id=6,City="cairo"}
               }

               },
                new HREmployee(){Id = 5,Name = "zizo",Salary=2000,
               Clients=new Client[]
               {
                   new Client(){Name="Abdo",Id=6,City="Mansoura" },
                   new Client(){Name="hamda",Id=7,City="mahalla"},
                  
               }

               },
               new PREmployee(){Id = 5,Name = "Capnizo",Salary=2000,
               Clients=new Client[]
               {
                   new Client(){Name="mostafa",Id=8,City="cairo" },
                   new Client(){Name="omar",Id=9,City="mahalla"},
                   new Client(){Name="Ali",Id=10,City="cairo"}
               }
               
               }
            };
            #endregion
            #region Tsk03
            printEmployeesDetails(employees);
            HREmployee emp1 = new HREmployee()
            {
                Id = 5,
                Name = "zizo",
                Salary = 2000,
                Clients = new Client[]
               {
                   new Client() { Name = "Ahmed", Id = 6, City = "Mansoura" },
                   new Client() { Name = "Mohamed", Id = 7, City = "mahalla" },
                   new Client() { Name = "Ahmed", Id = 6, City = "cairo" }
               }

            };
           HREmployee emp2 = new HREmployee()
           {
               Id = 5,
               Name = "zizo",
               Salary = 2000,
               Clients = new Client[]
               {
                   new Client() { Name = "Abdo", Id = 6, City = "Mansoura" },
                   new Client() { Name = "hamda", Id = 7, City = "mahalla" },

               }

           };
            HREmployee emp3 = new HREmployee()
            {
                Id = 5,
                Name = "Capnizo",
                Salary = 2000,
                Clients = new Client[]
               {
                   new Client() { Name = "mostafa", Id = 8, City = "cairo" },
                   new Client() { Name = "omar", Id = 9, City = "mahalla" },
                   new Client() { Name = "Ali", Id = 10, City = "cairo" }
               }
            };
            if (emp1 > emp2)
            {
                Console.WriteLine("employee 1 has clinets more than employee 2");
            };
            emp3 = emp1 + emp2;
            for (int i = 0; i < emp3.Clients.Length; i++) 
            {
                emp3.Clients[i].ShowClientDetaila();
            }



            #endregion
            #region Task04
            Student std1 = new Student() { Id = 1, UserEmail = "aa@gmail.com", UserName = "ahmed", UserPass = "aa" ,Password="123"};
            Student std2 = new Student() { Id = 2, UserEmail = "bb@gmail.com", UserName = "moahmed", UserPass = "bb", Password = "123" };
            Student std3 = new Student() { Id = 3, UserEmail = "cc@gmail.com", UserName = "ali", UserPass = "cc", Password = "123" };
            Authenticate A1=new Authenticate() { Std=std1}; 
            Authenticate A2=new Authenticate() { Std=std2}; 
            Authenticate A3 = new Authenticate() { Std = std3 };
            Console.WriteLine(A1.Login(1, "aa@gmail.com"));
            Console.WriteLine(A2.ForgetPassword("aa@gmail.com",1));
            Console.WriteLine(A3.ResetPassword(2,"123","321"));

            #endregion
        }
    }
    
}