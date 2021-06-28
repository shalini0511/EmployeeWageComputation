using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable

            int employeeState = 1, partTimeState = 2;
            int dailyWage, wageperHour = 20, hours = 8, partTimeHour = 4;
            Random random = new Random();
            int Attendance = random.Next(0, 3);
            Console.WriteLine("Random number is :" + Attendance);

            if ((partTimeState == Attendance) || (Attendance == employeeState))
            {
                Console.WriteLine("Employee is Present \n");
            }
            else
            {
                Console.WriteLine("Employee is Absent \n");

            }
            if (Attendance == 2)
            {
                hours = partTimeHour; Attendance = 1;
            }
            dailyWage = wageperHour * hours * Attendance;
            Console.WriteLine("Employee daily wage for 20/hr is : " + dailyWage);
        }

    }
    
    
}
