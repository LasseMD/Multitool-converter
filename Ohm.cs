using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    public class Ohm
    {

        public float U, R, I;

        public void CalcVolt()
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating U, Volt \n");
                try
                {
                    Console.Write("Enter R, Resistance: ");
                    R = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter I, Ampere: ");
                    I = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("U, Volt = " + I * R);

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


        public void CalcRes()
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating R, Resistance \n");
                try
                {
                    Console.Write("Enter U, Volt: ");
                    U = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter I, Ampere: ");
                    I = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    System.Console.WriteLine("R, Resistance = " + U / I);

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


        public void CalcAmp()
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                Console.WriteLine("You are now calculating I, Ampere \n");
                try
                {
                    Console.Write("Enter U, Volt: ");
                    U = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter R, Resistance: ");
                    R = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine();
                    System.Console.WriteLine("I, Ampere = " + U / R);

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