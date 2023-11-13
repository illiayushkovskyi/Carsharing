using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nice ti see You in our servise Carsaring LasVegas");
            string welcome = "Thank You! We value the safety of our customers.";
            string ask;

            Console.WriteLine("Please tell me if You have a driver's license (yes or no)");
            ask = Console.ReadLine();
            welcome += ask == "yes" ? " We will be glad to work with You!" : " You can see our offers 00 ";
            Console.WriteLine(welcome);

            Console.WriteLine("Car park at Your servise!");
            Console.WriteLine("What type of car do you prefer?");
            Console.WriteLine("1 - Maybach w222");
            Console.WriteLine("2 - Ferrari Roma");
            Console.WriteLine("3 - Lamborghini Ursus");
            Console.WriteLine("4 - Bentley Continental");
            Console.WriteLine("5 - Bugatti Divo");
            Console.WriteLine("6 - Rolls-Royce Sweptail");

            string typcar = Console.ReadLine();
            int prise = 0;

            switch (typcar)
            {
                case "1":
                    prise += 500;
                    break;
                case "2":
                    prise += 100;
                    goto case "1";
                case "3":
                    prise += 150;
                    goto case "1";
                case "4":
                    prise += 200;
                    goto case "1";
                case "5":
                    prise += 500;
                    goto case "1";
                case "6":
                    prise += 1000;
                    goto case "1";

                default:
                    Console.WriteLine("Error");
                    break;
            }
            

                    Console.WriteLine("What typ of insurance do you prefer?");
                    Console.WriteLine("1 - Freeway Insurance");
                    Console.WriteLine("2 - Weston Prince: Allstate Insurance");
                    Console.WriteLine("3 - Farmers Insurance - Alejandro Vazques");

                    string insurance = Console.ReadLine();
            switch (insurance)
            {
                case "1":
                    prise += 50;
                    break;
                case "2":
                    prise += 60;
                    goto case "1";
                case "3":
                    prise += 75;
                    goto case "1";

                default:
                    Console.WriteLine("Error");
                    break;
            }

                            Console.WriteLine("Do you need accompaniment?");
                            Console.WriteLine("1 - No");
                            Console.WriteLine("2 - Personal driver");
                            Console.WriteLine("3 - Personal driver and escort");

                            string accompaniment = Console.ReadLine();
            switch (accompaniment)
            {
                case "1":
                    prise += 0;
                    break;
                case "2":
                    prise += 150;
                    goto case "1";
                case "3":
                    prise += 400;
                    goto case "1";

                default:
                    Console.WriteLine("Error");
                    break;
            }

                                    Console.WriteLine("Do you need delivery Your car?");
                                    Console.WriteLine("1 - No");
                                    Console.WriteLine("2 - Otels in LasVegas");
                                    Console.WriteLine("3 - Airport Nort-Las-Vegas");
                                    Console.WriteLine("3 - Airport Mackkaran");

                                    string delivery = Console.ReadLine();

            switch (delivery)
            {
                case "1":
                    prise += 0;
                    break;
                case "2":
                    prise += 50;
                    goto case "1";
                case "3":
                    prise += 100;
                    goto case "1";
                case "4":
                    prise += 150;
                    goto case "1";
                default:
                    Console.WriteLine("Error");
                    break;
            }

            if (prise == 0)
            {
                Console.WriteLine("Please try again");
            }
            else
            {
                Console.WriteLine("Your expenses {0} $ in one day", prise);
                Console.WriteLine("Make payment");

                int payment = Convert.ToInt32(Console.ReadLine());
                if (payment >= prise)
                {
                    Console.WriteLine("Thanks! Good Luck!");
                    Console.WriteLine("Your change {0}$", payment - prise);

                }
                else
                {
                    Console.WriteLine("not enoudht money!");
                }

            










        }
            Console.ReadKey();
        }
    }
}
