using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int employeePresent  = 1;
            int empHours = 0;
            int empRatePerHour = 20;
            int empWage = 0;
            //creating object
            Random random = new Random();
            //calling Next() for generating random values
            int Attendance = random.Next(0, 2);
            Console.WriteLine("Random number is :" + Attendance);

            if (Attendance == employeePresent)
            {
                Console.WriteLine("Employee is Present \n");
                empHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent \n");
                empHours = 0;

            }
            empWage = empRatePerHour * empHours;
            Console.Read();
        }
    }
    
}
