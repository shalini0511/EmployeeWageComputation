using System;

namespace EmployeeWages
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //  private static int maxHoursPerMonth;

        // public const int WAGE_PER_HOUR = 20;
        // public const int WORKING_PER_MONTH = 20;
        //public const int MAX_WORKING_DAYS = 20;
        //public const int MAX_WORKING_HRS = 100;
        public static void ComputeWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
        {
            //Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 1;
            int workingHrs = 0;
            int totalWage = 0;

            Random r = new Random();

            while (workingDays <= max_working_days && workingHrs <= maxHoursPerMonth)
            {
                //Calling the next method in Random Class
                int empAttendance = r.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        // Console.WriteLine("Employee is present for full-time");
                        empHours = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent");
                        break;

                }
                empDailyWage = empHours * wage_per_hour;
                totalWage += empDailyWage;
                workingHrs += empHours;
                if (empAttendance != 0)
                {
                    workingDays++;
                }
            }
            Console.WriteLine("Company Name:" + company);
            Console.WriteLine("Working Hours :" + workingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Working days in a month :" + workingDays);
            Console.WriteLine("Employee Wage for 20 working days :" + totalWage);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            ComputeWage("TVSNEXT", 80, 12, 90);
            ComputeWage("Wipro", 55, 22, 110);
            ComputeWage("RoyalEnfield", 78, 32, 120);
        }
    }

}
    
    

