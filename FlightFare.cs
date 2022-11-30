using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment14_11_2022
{
    internal class Flight
    {
            public float[] FlightFares = new float[10];
            private float temp;
            private float maxval;
            private float minval;

            public void EnterData()
            {
                for (int i = 0; i < FlightFares.Length; i++)
                {
                    Console.Write($"{i + 1}. Enter the Flight Fare : ");
                    FlightFares[i] = float.Parse(Console.ReadLine());
                }
            }

            public void Asort()
            {

                for (int i = 0; i < FlightFares.Length; i++)
                {
                    for (int j = i+1; j < FlightFares.Length; j++)
                    {
                        if (FlightFares[i] < FlightFares[j])
                        {
                            temp = FlightFares[i];
                            FlightFares[i] = FlightFares[j];
                            FlightFares[j] = temp;
                        }
                    }
                }


                foreach (var item in FlightFares)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

            }
            public void Dsort()
            {

                for (int i = 0; i < FlightFares.Length; i++)
                {
                    for (int j = 0; j < FlightFares.Length; j++)
                    {
                        if (FlightFares[i] > FlightFares[j])
                        {
                            temp = FlightFares[i];
                            FlightFares[i] = FlightFares[j];
                            FlightFares[j] = temp;
                        }
                    }
                }


                foreach (var item in FlightFares)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }


            public void SearchFare()
            {
                bool flag = false;
                Console.WriteLine("Enter the name to be searched : ");
                temp = float.Parse(Console.ReadLine());

                for (int i = 0; i < FlightFares.Length; i++)
                {
                    if (temp == FlightFares[i])
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                    Console.WriteLine("The fare is there in the Flight fare Array");
                else
                    Console.WriteLine("The name is not there in the Flight fare Array");

            }

            public void minmaxval()
            {
                for (int i = 0; i < FlightFares.Length; i++)
                {
                    for (int j = 0; j < FlightFares.Length; j++)
                    {
                        if (FlightFares[i] < FlightFares[j])
                        {
                            temp = FlightFares[i];
                            FlightFares[i] = FlightFares[j];
                            FlightFares[j] = temp;
                        }
                    }
                }

                minval = FlightFares[0];
                maxval = FlightFares[FlightFares.Length - 1];

                Console.WriteLine($"Maximum flight fare : {maxval}");
                Console.WriteLine($"Minimum flight fare : {minval}");
            }


            public void duplicate()
            {
                var duplicates = new float[FlightFares.Length];
                int k = 0;
                foreach (var number in FlightFares)
                {
                    int count = 0;
                    foreach (var item in FlightFares)
                    {
                        if (number == item)
                            count++;
                    }
                    if (count >= 2)
                    {
                        bool hasFoundMatch = false;
                        foreach (var num in duplicates)
                        {
                            if (num == number)
                            {
                                hasFoundMatch = true;
                                break;
                            }
                        }
                        if (!hasFoundMatch)
                            duplicates[k++] = number;
                    }
                }
                foreach (var item in duplicates)
                {
                    if (item == 0)
                        break;
                    else
                        Console.WriteLine($"{item} ");

                }

            }
        }
    }