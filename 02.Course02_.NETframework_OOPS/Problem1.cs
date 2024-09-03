using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EmpId;
            string EmpName;
            string EmpJob;
            int EmpSal;

            Console.WriteLine("Enter the Employee ID");
            EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter the Employee Job Title");
            EmpJob = Console.ReadLine();

            Console.WriteLine("Enter the Salary");
            EmpSal = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Employee Id: " + EmpId);
            Console.WriteLine();
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine();
            Console.WriteLine("Employee Job: " + EmpJob);
            Console.WriteLine();
            Console.WriteLine("Employee Salary: " + EmpSal);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
