using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    public class Speed
    {

        public float speed, distance, time;


        public void CalcSpeed()
        // Speed = Distance / Time h
        {
            bool TryAgain = true;

            while (TryAgain == true)
            {


                Console.WriteLine("You are now calculating speed. Please enter the following parameters.\n");
                try
                {
                    Console.Write("Distance in kilometers: ");

                    distance = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Time in minutes: ");

                    time = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Your speed is: " + distance / (time / 60) + " km/h");
                    Console.WriteLine("\nPress Enter to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    TryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                    Console.WriteLine();
                }
            }
        }





        public void CalcDistance()
        // Distance = Speed* Time h
        {
            bool TryAgain = true;

            while (TryAgain == true)
            {


                Console.WriteLine("You are now calculating distance. Please enter the following parameters.\n");
                try
                {
                    Console.Write("Speed in kilometers per hour: ");

                    speed = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Time in minutes: ");

                    time = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Your distance is: " + speed * (time / 60) + " km");
                    Console.WriteLine("\nPress Enter to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    TryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                    Console.WriteLine();
                }
            }
        }






        public void CalcTime()
        // Time = Distance / Speed
        {
            bool TryAgain = true;

            while (TryAgain == true)
            {


                Console.WriteLine("You are now calculating time. Please enter the following parameters.\n");
                try
                {
                    Console.Write("Distance in kilometers: ");

                    distance = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Speed in kilometers per hour: ");

                    speed = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Your time is: " + (distance / speed) * 60 + " minutes");
                    Console.WriteLine("\nPress Enter to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    TryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                    Console.WriteLine();
                }
            }
        }


    }
}
