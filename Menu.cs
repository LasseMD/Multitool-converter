using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    public class Menu
    {
        public byte MainMenu()
        {
            byte UserInput;
            Console.WriteLine("Select one of six options by typing the number 1-6: ");
            Console.WriteLine("");
            Console.WriteLine("1)  Ohm's Law Calculator ");
            Console.WriteLine("2)  Convert between Fahrenheit / Celsius / Kelvin");
            Console.WriteLine("3)  Convert between Inches / Cm / Feet / Yards / M");
            Console.WriteLine("4)  Calculate Speed, Time in minutes and Distance in km");
            Console.WriteLine("5)  Calculate the area and / or volume of different figures: Rectangle, Triangle, Circle, Cube, Pyramid, Sphere.");
            Console.WriteLine("6)  Exit");
            Console.WriteLine("");
            UserInput = Convert.ToByte(Console.ReadLine());

            return UserInput;
        }

        public byte OhmMenu()
        {
            Console.Clear();

            byte OhmMenu;

            Console.WriteLine("You are now calculating Ohm. Please choose between U = Volt, R = Resistance and I = Ampere.");
            Console.WriteLine("Select one of four options by typing the number 1-4: ");
            Console.WriteLine();
            Console.WriteLine("1)  Calculate U = Volt ");
            Console.WriteLine("2)  Calculate R = Resistance ");
            Console.WriteLine("3)  Calculate I = Ampere ");
            Console.WriteLine("4)  Go back to main menu");
            OhmMenu = Convert.ToByte(Console.ReadLine());

            return OhmMenu;
        }

        public byte TempMenu()
        {
            Console.Clear();

            byte TempMenu;

            Console.WriteLine("You are now converting temperatures");
            Console.WriteLine("Select one of four options by typing the number 1-4: ");
            Console.WriteLine();
            Console.WriteLine("1)  Enter Celsius and convert to Fahrenheit and Kelvin ");
            Console.WriteLine("2)  Enter Kelvin and convert to Fahrenheit and Celsius");
            Console.WriteLine("3)  Enter Fahrenheit and convert to Celsius and Kelvin");
            Console.WriteLine("4)  Go back to main menu");
            TempMenu = Convert.ToByte(Console.ReadLine());

            return TempMenu;
        }

        public byte LenghtMenu()
        {
            Console.Clear();

            byte LenghtMenu;

            Console.WriteLine("You are now converting length.");
            Console.WriteLine("Select one of six options by typing the number 1-6: ");
            Console.WriteLine();
            Console.WriteLine("1)  Enter CM and convert to Inch, Yard, Feet, Meter. ");
            Console.WriteLine("2)  Enter METER and convert to CM, Yard, Feet, Inch.  ");
            Console.WriteLine("3)  Enter INCH and convert to CM, Yard, Feet, Meter. ");
            Console.WriteLine("4)  Enter FEET and convert to Inch, Yard, Feet, Meter.");
            Console.WriteLine("5)  Enter YARD and convert to Inch, CM, Feet, Meter.");
            Console.WriteLine("6)  Go back to main menu");
            LenghtMenu = Convert.ToByte(Console.ReadLine());

            return LenghtMenu;
        }



        public byte SpeedMenu()
        {
            Console.Clear();

            byte SpeedMenu;

            Console.WriteLine("You are now calculating speed, distance and time.");
            Console.WriteLine("Select one of four options by typing the number 1-4: ");
            Console.WriteLine();
            Console.WriteLine("1)  Calculate Speed ");
            Console.WriteLine("2)  Calculate Distance");
            Console.WriteLine("3)  Calculate Time");
            Console.WriteLine("4)  Go back to main menu");
            SpeedMenu = Convert.ToByte(Console.ReadLine());

            return SpeedMenu;
        }




        public byte AreaMenu()
        {
            Console.Clear();

            byte AreaMenu;

            Console.WriteLine("You are now calculating Area and Volume.");
            Console.WriteLine("Select one of seven options by typing the number 1-7: ");
            Console.WriteLine();
            Console.WriteLine("1)  Calculate area of a Circle");
            Console.WriteLine("2)  Calculate area of a Rectangle");
            Console.WriteLine("3)  Calculate area of a Triangle");
            Console.WriteLine("4)  Calculate volume of a Cube");
            Console.WriteLine("5)  Calculate volume of a Pyramid");
            Console.WriteLine("6)  Calculate volume of a Sphere");
            Console.WriteLine("7)  Go back to main menu");
            AreaMenu = Convert.ToByte(Console.ReadLine());

            return AreaMenu;
        }
    }
}