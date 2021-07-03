using System;

namespace EmployeeWages
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //  private static int maxHoursPerMonth;
        //public string company;
        //public  int WAGE_PER_HOUR;
        //public  int maxHoursPerMonth;
        //public  int max_working_days;
        //public  int wage_per_hour;

        //   public Program(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
        // {
        //   this.company = company;
        // this.wage_per_hour = wage_per_hour;
        //this.max_working_days = max_working_days;
        //this.maxHoursPerMonth = maxHoursPerMonth;
        //}
        public class EmpBuilderWage
        {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;
            private int numOfCompany = 0;
            private int empDailyWage = 0;
            private CompanyEmpWage[] companyEmpWageArray;
            private int totalWage;
            private int wagePerHour;

            public EmpBuilderWage()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
            {
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, wagePerhour, maxHoursPerMonth, maxWorkingDays);
                numOfCompany++;
            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }
            private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
            {
                //Console.WriteLine("Welcome to employee wage computation");
                //Creating a Random Function
                int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0, workingHrs = 0;


                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.maxWorkingDays)
                {
                    //Calling the next method in Random Class
                    totalWorkingDays++;
                    Random r = new Random();
                    int empAttendance = r.Next(0, 3);
                    switch (empAttendance)
                    {
                        case FULL_TIME:
                            empHours = 8;
                            break;
                        case PART_TIME:
                            empHours = 4;
                            break;
                        default:
                            empHours = 0;
                            break;

                    }

                    totalEmpHrs += empHours;


                }

                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hours : " + empHours);
                return totalEmpHrs * companyEmpWage.wagePerHour;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to employee wage computation");
                EmpBuilderWage empBuilderWage = new EmpBuilderWage();
                empBuilderWage.addCompanyEmpWage("TvsNext", 20, 15, 10);
                empBuilderWage.addCompanyEmpWage("wipro", 10, 20, 20);
                empBuilderWage.ComputeEmpWage();
            }
        }
    }
}
    
    

