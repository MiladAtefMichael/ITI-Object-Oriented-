using System;

namespace Lab05
{
    struct Company
    {
		private string companyName;

		public string CompanyName
		{
			get { return companyName; }
			set { companyName = value; }
		}
		private Department[]  departments;

		public Department[]  Departments
		{
			get { return departments; }
			set { departments = value; }
		}
		public void printCompanyData()
		{
			Console.WriteLine($"company name is {companyName}");
			for (int i=0;i<departments.Length;i++)
			{
				departments[i].PrintDepartment();
			}
		}


	}
}
