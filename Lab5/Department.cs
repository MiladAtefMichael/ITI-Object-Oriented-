using System;

namespace Lab05
{
    struct Department
    {
		private string depName;

		public string DepName
		{
			get { return depName; }
			set { depName = value; }
		}
		private string manager;

		public string Manager
		{
			get { return manager; }
			set { manager = value; }
		}
	   private Employee[] staff;

		public Employee[] Staff
	   {
			get { return staff; }
			set { staff = value; }
	   }
	   public void PrintDepartment()
	   {
			Console.WriteLine($"Department Name : {depName}");
			for(int i=0;i<staff.Length;i++)
			{
				staff[i].PrintEmployeeData();
			}

	   }



	}
}