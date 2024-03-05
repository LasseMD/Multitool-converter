using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    class LengthUnit
    {
        public float Meter, Yard, Feet, Inch, Cm;


        public void ConvertCm()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many CM do you want to convert?");
                try
                {
                    Cm = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Cm + " Centimeters = " + (Cm / 100) + " Meters.");
                    Console.WriteLine(Cm + " Centimeters = " + (Cm * 0.3937) + " Inch.");
                    Console.WriteLine(Cm + " Centimeters = " + (Cm * 0.0328083) + " Feet.");
                    Console.WriteLine(Cm + " Centimeters = " + (Cm * 0.01936133) + " Yard.");

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
        public void ConvertMeter()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many Meter do you want to convert?");
                try
                {
                    Meter = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Meter + " Meters = " + (Meter * 100) + " CM.");
                    Console.WriteLine(Meter + " Meters = " + (Meter * 39.37) + " Inch.");
                    Console.WriteLine(Meter + " Meters = " + (Meter * 3.28083) + " Feet.");
                    Console.WriteLine(Meter + " Meters = " + (Meter * 1.936133) + " Yard.");

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

        public void ConvertInch()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many Meter do you want to convert?");
                try
                {
                    Inch = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Inch + " Inch = " + (Inch * 2.54) + " CM.");
                    Console.WriteLine(Inch + " Inch = " + (Inch * 0.0254) + " Meter.");
                    Console.WriteLine(Inch + " Inch = " + (Inch * 0.083333) + " Feet.");
                    Console.WriteLine(Inch + " Inch = " + (Inch * 0.0277778) + " Yard.");

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

        public void ConvertFeet()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many Feet do you want to convert?");
                try
                {
                    Feet = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Feet + " Feet = " + (Feet * 30.48) + " CM.");
                    Console.WriteLine(Feet + " Feet = " + (Feet * 0.3048) + " Meter.");
                    Console.WriteLine(Feet + " Feet = " + (Feet * 12) + " Inch.");
                    Console.WriteLine(Feet + " Feet = " + (Feet * 0.333333) + " Yard.");

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


        public void ConvertYard()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many Yard do you want to convert?");
                try
                {
                    Yard = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Yard + " Yard = " + (Yard * 91.44) + " CM.");
                    Console.WriteLine(Yard + " Yard = " + (Yard * 0.9144) + " Meter.");
                    Console.WriteLine(Yard + " Yard = " + (Yard * 36) + " Inch.");
                    Console.WriteLine(Yard + " Yard = " + (Yard * 3) + " Feet.");

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
