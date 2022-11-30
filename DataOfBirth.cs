using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment14_11_2022
{
    internal class PDateofBirth
    {
        public DateOnly DateofBirth;
        public DateOnly Today;

        public void SetData()
        {
            Console.WriteLine("Enter DOB : ");
            DateofBirth = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Today : ");
            Today = DateOnly.Parse(Console.ReadLine());
        }
        public void GetData()
        {
            Console.WriteLine("Date of Birth : " + DateofBirth);

        }
        public void Details()
        {
            var days = Today.DayNumber - DateofBirth.DayNumber;
            Console.WriteLine("Days Completed : " + days);
            Console.WriteLine("Hours Completed : " + days * 24);
            Console.WriteLine("Weeks Completed : " + days / 7);
            Console.WriteLine("Months Completed : " + days / 30);
            Console.WriteLine("Years Completed : " + days / 365);
            var years = DateofBirth.Year;
            if (years % 4 == 0)
            {
                Console.WriteLine($"{DateofBirth} is a leap Year ");
            }
            else if (years % 1 != 0 && years % 4 == 0)
            {
                Console.WriteLine($"{DateofBirth} is a leap Year ");

            }
            else
            {
                Console.WriteLine($"{DateofBirth} is Not a leap Year ");

            }


        }
    }
}