using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    // Celsius - Kelvin = Celsius + 273,15 = Kelvin
    // Celsius - Fahrenheit = Celsius / 5 * 9 + 32 = Fahrenheit

    // Kelvin - Celsius = Kelvin - 273,15 = Celsius
    // Kelvin - Fahrenheit = (Kelvin - 273,15) * 9 / 5 + 32 = Fahrenheit

    // Fahrenheit - Celsius = (Fahrenheit - 32) * 5 / 9 = Celsius 
    // Fahrenheit - Kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15 = Kelvin
    public class Temperatures
    {
        public float Celsius, Fahrenheit, Kelvin;



        public void ConvertCel()
        {
            bool TryAgain = true;
            
            
            while (TryAgain == true)
            {
                Console.WriteLine("How many degrees Celsius do you want to convert?");
                try
                {
                    Celsius = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Celsius + " degrees Celsius = " + (Celsius + 273.15) + " degrees Kelvin.");
                    Console.WriteLine(Celsius + " degrees Celsius = " + (Celsius / 5 * 9 + 32) + " degrees Fahrenheit.");
                   
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



        public void ConvertKel()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many degrees Kelvin do you want to convert?");
                try
                {
                    Kelvin = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Kelvin + " degrees Kelvin = " + (Kelvin - 273.15) + " degrees Celsius.");
                    Console.WriteLine(Kelvin + " degrees Kelvin = " + ((Kelvin - 273.15) * 9 / 5 + 32) + " degrees Fahrenheit.");
                    
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






        public void ConvertFah()
        {
            bool TryAgain = true;


            while (TryAgain == true)
            {
                Console.WriteLine("How many degrees Fahrenheit do you want to convert?");
                try
                {
                    Fahrenheit = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Fahrenheit + " degrees Fahrenheit = " + ((Fahrenheit - 32) * 5 / 9) + " degrees Celsius.");
                    Console.WriteLine(Fahrenheit + " degrees Fahrenheit = " + ((Fahrenheit - 32) * 5 / 9 + 273.15) + " degrees Kelvin.");
                    
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
