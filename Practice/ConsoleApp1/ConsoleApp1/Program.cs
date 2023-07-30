using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Branch
    {
        int BranchCode;
        string BranchName, BranchAddress;
        public void GetBranchData()
        {
            Console.WriteLine("ENTER BRANCH DETAILS:");
            Console.WriteLine("ENTER BRANCH CODE");
            
            Console.WriteLine("ENTER BRANCH NAME");
            
            Console.WriteLine("ENTER BRANCH ADDRESS");
            BranchAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("BRANCH CODE IS : " + BranchCode);
            Console.WriteLine("BRANCH NAME IS : " + BranchName);
            Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
        }
    }
    class Employee : Branch
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE ID");
            
            Console.WriteLine("ENTER EMPLOYEE AGE");
           
            Console.WriteLine("ENTER EMPLOYEE NAME");
           
            Console.WriteLine("ENTER EMPLOYEE ADDRESS");
            
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee(10,"Sakib","khulna");

            obj1.GetBranchData();
            obj1.GetEmployeeData();
            obj1.DisplayBranchData();
            obj1.DisplayEmployeeData();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
