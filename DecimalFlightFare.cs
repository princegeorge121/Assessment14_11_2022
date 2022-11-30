using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment14_11_2022
{
    internal class FlightEvenOrOdd
    {
        public int[] FlightFare = new int[50];
        public int fare { get; set; }

        public void Assign()
        {
            int count = 0;
            char f = 'y';

            while (f == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Number");
                fare = int.Parse(Console.ReadLine());
                FlightFare[count] = fare;
                count = count + 2;
                Console.WriteLine("Do you want to Enter more?");
                f = char.Parse(Console.ReadLine());

            }

            Array.Resize(ref FlightFare, (count + 1));

            for (int i = 0; i < FlightFare.Length; i = i + 2)
            {
                if (FlightFare[i] == 0)
                    break;
                else
                    Console.Write(FlightFare[i] + " ");
            }

            Console.WriteLine();

            foreach (var item in FlightFare)
            {
                Console.Write(item + " ");
            }
        }

    }
}