using System;

namespace Class1
{
    public class Employee
    {
        public static void GetInfo()
        {    
            
            Console.Write("How Much Do You Earn: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("How Many hours Do You Work Per Day: ");
            int hours = int.Parse(Console.ReadLine());

            int bonusSalary1 = salary + 10;

            AddSalary(salary);
            AddHoursWorkPerDay(salary, hours, bonusSalary1);
        }
        public static void AddSalary( int salary)
        {
            int bonusSalary1 = salary + 10;
            if(salary < 500)
            {
                Console.WriteLine($"Your bonus has been Added To Your Salary{bonusSalary1} ");
            }
            // else
            // {
            //     Console.WriteLine("Sorry...!!! No Bonus Added");
            // }
            
        }
        public static void AddHoursWorkPerDay( int salary, int hours, int bonusSalary1)
        {
            int bonusSalary2 = bonusSalary1 + 5;
            if( hours > 6 && salary<500)
              {
                Console.WriteLine($" Your new salary is {bonusSalary2}");
              }

              else if(hours < 6 && salary < 500)
              {
                Console.WriteLine($"Your new salary is:{bonusSalary2}");
              }

              else if(hours > 6 && salary > 500)
              {
                Console.WriteLine($"Your new salary is: {bonusSalary2}");
              }

              else
              {
                Console.WriteLine($"You Have No Bonus Rewarded {salary}");
              }
        }

    }
}
