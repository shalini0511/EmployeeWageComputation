using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeState = 1;
            Random random = new Random();
            int Attendance = random.Next(0, 2);
            Console.WriteLine("Random number is :" + Attendance);

            if (Attendance == employeeState)
            {
                Console.WriteLine("Employee is Present \n");
            }
            else
            {
                Console.WriteLine("Employee is Absent \n");

            }
        }
    }
    
}
