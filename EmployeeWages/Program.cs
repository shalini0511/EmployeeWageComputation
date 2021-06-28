using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int dailyWage, wageperHour = 20, hours = 8, partTimeHour = 4, days = 20;
            Random random = new Random();
            int Attendance = random.Next(0, 3);
            Console.WriteLine("Random number is :" + Attendance);
            switch (Attendance)
            {
                case 1:
                    Console.WriteLine("Employee is Present \n");
                    break;
                case 2:
                    Console.WriteLine("Parttimer is Present");
                    hours = partTimeHour; Attendance = 1;
                    break;
                default:
                    Console.WriteLine("Employee is Absent \n");
                    break;
            }

            dailyWage = wageperHour * hours * Attendance;
            Console.WriteLine("Employee daily wage for 20/hr is : " + dailyWage);
            Console.WriteLine("Employee wage for 20 days  is : " + dailyWage * days);



        }

    }
    
    
}
