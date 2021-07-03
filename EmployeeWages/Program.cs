using System;

namespace EmployeeWages
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //  private static int maxHoursPerMonth;
        public string company;
        public int WAGE_PER_HOUR;
        public int maxHoursPerMonth;
        public int max_working_days;
        public int wage_per_hour;

    public Program(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
    {
        this.company = company;
        this.wage_per_hour = wage_per_hour;
        this.max_working_days = max_working_days;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void ComputeWage()
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
        Program tvsnext = new Program("Infosys", 80, 12, 90);
        tvsnext.ComputeWage();
        Program wipro = new Program("TCS", 55, 22, 110);
        wipro.ComputeWage();

    }
}  
}
    
    

