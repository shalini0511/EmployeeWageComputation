using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int employeeStatus;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            int monthlyWage = 0;


            int wagePerHour = 20;
            Random random = new Random();
            employeeStatus = random.Next(0, 3);

            switch (employeeStatus)
            {
                case 1:
                    Console.WriteLine("Full time- Employee Present");
                    while (totalWorkingDays <= 20 && totalWorkingHours <= 100)
                    {
                        totalWorkingHours = totalWorkingHours + 8;
                        totalWorkingDays++;
                        monthlyWage = monthlyWage + (wagePerHour * 8);
                    }
                    Console.WriteLine("Total wage for month is:" + monthlyWage);

                    break;
                case 0:
                    Console.WriteLine("Employee Absent");
                    break;
                case 2:
                    Console.WriteLine("part time- Employee Present");
                    while (totalWorkingDays <= 20 && totalWorkingHours <= 100)
                    {
                        totalWorkingHours = totalWorkingHours + 4;
                        totalWorkingDays++;
                        monthlyWage = monthlyWage + (wagePerHour * 4);
                    }
                    Console.WriteLine("Total wage for month is: " + monthlyWage);
                    break;

            }
            


        }

    }
    
    
}
