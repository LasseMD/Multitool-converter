using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    internal class Area_Volume
    {
      
        double Pi = Math.PI;
        double Depth;
        double Height;
        double Width;
        double Radial;



        //---------------------- start of volume -------------------
        public void CalcVolPyr()  // Pyramid, Volume = ( Basytans Area (Base * Depth) ) * Height / 3
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating volume of a Pyramid. Enter values in meters \n");
                try
                {
                    Console.Write("Enter width of pyramid: ");
                    Width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter depth of pyramid: ");
                    Depth = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter height of pyramid: ");
                    Height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The volume of your pyramid is: " + (Width * Depth) * Height / 3 + " Cubic meters \n");

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



        public void CalcVolSphere() // Sphere, Volume = 4ñ * r^3 / 3
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating volume of a Sphere. Enter values in meters \n");
                try
                {
                    Console.Write("Enter radial of sphere: ");
                    Radial = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The volume of your sphere is: " + 4 * Pi * (Radial * Radial * Radial) / 3 + " Cubic meters \n");

                    Console.WriteLine("Press Enter to return to main menu.");
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




        public void CalcVolCube() // Cube, Volume = Base * Height * Depth
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating volume of a Cube. Enter values in meters \n");
                try
                {
                    Console.Write("Enter width of cube: ");
                    Width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter depth of cube: ");
                    Depth = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter height of cube: ");
                    Height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The volume of your cube is: " + Width * Height * Depth + " Cubic meters \n");

                    Console.WriteLine("Press Enter to return to main menu.");
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

        //---------------------- end of volume -------------------



        //---------------------- start of areea -------------------

        public void CalcAreaRec() // Rectangle, Area = Base * Height
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating area of a Rectangle. Enter values in meters \n");
                try
                {
                    Console.Write("Enter width of rectangle: ");
                    Width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter height of rectangle: ");
                    Height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The area of your rectangle is: " + Width * Height + " Square meters \n");

                    Console.WriteLine("Press Enter to return to main menu.");
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





        public void CalcAreaTri() // Triangle, Area = Base * Height / 2
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating area of a Triangle. Enter values in meters \n");
                try
                {
                    Console.Write("Enter width of triangle: ");
                    Width = Convert.ToDouble(Console.ReadLine());


                    Console.Write("Enter height of triangle: ");
                    Height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The area of your triangle is: " + Width * Height / 2 + " Square meters \n");

                    Console.WriteLine("Press Enter to return to main menu.");
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




        public void CalcAreaCircle() // Circle, Area = Radial^2 * ñ (Pi. 3,1415)
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating area of a Circle. Enter values in meters \n");
                try
                {
                    Console.Write("Enter radial of circle: ");
                    Radial = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The area of your circle is: " + (Radial * Radial) * Pi + " Square meters \n");

                    Console.WriteLine("Press Enter to return to main menu.");
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


        //---------------------- end of area -------------------
    }
}
