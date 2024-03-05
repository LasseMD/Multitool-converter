using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace group2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TryAgain = true;
            while (TryAgain == true)
            {
                try
                {
                    Menu menu = new Menu();
                    byte UserInput = menu.MainMenu();

                    if (UserInput == 1)
                    {
                        Ohm ohm = new Ohm();
                        byte OhmMenu = menu.OhmMenu();

                        if (OhmMenu == 1)
                        {
                            ohm.CalcVolt();
                        }

                        if (OhmMenu == 2)
                        {
                            ohm.CalcRes();
                        }

                        if (OhmMenu == 3)
                        {
                            ohm.CalcAmp();
                        }
                    }
                    if (UserInput == 2)
                    {
                        Temperatures temperatures = new Temperatures();

                        byte TempMenu = menu.TempMenu();


                        if (TempMenu == 1)
                        {
                            temperatures.ConvertCel();
                        }

                        if (TempMenu == 2)
                        {
                            temperatures.ConvertKel();
                        }

                        if (TempMenu == 3)
                        {
                            temperatures.ConvertFah();
                        }
                    }
                    if (UserInput == 3)
                    {
                        LengthUnit lengthunit = new LengthUnit();
                        byte LengthMenu = menu.LenghtMenu();

                        if (LengthMenu == 1)
                        {
                            lengthunit.ConvertCm();
                        }

                        if (LengthMenu == 2)
                        {
                            lengthunit.ConvertMeter();
                        }

                        if (LengthMenu == 3)
                        {
                            lengthunit.ConvertInch();
                        }

                        if (LengthMenu == 4)
                        {
                            lengthunit.ConvertFeet();
                        }

                        if (LengthMenu == 5)
                        {
                            lengthunit.ConvertYard();
                        }
                    }
                    if (UserInput == 4)
                    {
                        Speed speed = new Speed();
                        byte SpeedMenu = menu.SpeedMenu();


                        if (SpeedMenu == 1)
                        {
                            speed.CalcSpeed();
                        }

                        if (SpeedMenu == 2)
                        {
                            speed.CalcDistance();
                        }

                        if (SpeedMenu == 3)
                        {
                            speed.CalcTime();
                        }
                    }
                    if (UserInput == 5)
                    {
                       
                        Area_Volume area = new Area_Volume();
                        byte AreaMenu = menu.AreaMenu();


                        if (AreaMenu == 1)
                        {
                            area.CalcAreaCircle();
                        }

                        if (AreaMenu == 2)
                        {
                            area.CalcAreaRec();
                        }

                        if (AreaMenu == 3)
                        {
                            area.CalcAreaTri();
                        }
                        if (AreaMenu == 4)
                        {
                            area.CalcVolCube();
                        }
                        if (AreaMenu == 5)
                        {
                            area.CalcVolPyr();
                        }
                        if (AreaMenu == 6)
                        {
                            area.CalcVolSphere();
                        }
                    }
                    if (UserInput == 6)
                    {
                        System.Console.WriteLine("See you later!");
                        System.Console.WriteLine("");
                        break;
                    }
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

