using System;

namespace OutVariables
{
    //example 1
    //Work with the Out Parameter Before C# 7
    /*
    class Program
    {
        static void Main()
        {
            string EmployeeName, Gender, Department;
            long Salary;
            GetEmployeeDetails(out EmployeeName, out Gender, out Salary, out Department);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            EmployeeName, Gender, Salary, Department);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
           EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }

    }*/
    //example 2
    //Working with Out Variable in C# 7.
    /*
    class Program
{
    static void Main()
    {
        GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department);
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
        EmployeeName, Gender, Salary, Department);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
    {
        EmployeeName = "Pranaya Rout";
        Gender = "Male";
        Salary = 20000;
        Department = "IT";
    }
    }*/

    //example 3
    //Can we declare the out variable with var data type from C# 7?
    /*class Program
    {
        static void Main()
        {
            GetEmployeeDetails(out var EmployeeName, out var Gender, out var Salary, out var Department);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            EmployeeName, Gender, Salary, Department);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }*/
    //Example 4
    //Ignore an out parameter in C#
    /*class Program
    {
        static void Main()
        {
            GetEmployeeDetails(out var EmployeeName, out var Gender, out var Salary, out  _);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}",
            EmployeeName, Gender, Salary);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }*/

    //example 5
    //Out Parameter Using TryParse
    class Program
    {
        static void Main()
        {
            string s = "09-Jun-2018";
            DateTime date;
            if (DateTime.TryParse(s, out date))
            {
                Console.WriteLine(date);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}
