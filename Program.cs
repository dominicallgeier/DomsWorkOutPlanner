using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace DomsWorkOutPlanner
{
    class Program
    {
       static List<string> responses = new List<string>();
        
    static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
           
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            
            Console.WriteLine("Welcome to Dominic's Fitness Planner!");
            
            Console.WriteLine("*************************************");
            
            Console.WriteLine("*************************************");
            
            Console.WriteLine("Create your own work out!");
            
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("Please select a category you want to work out:");
            Console.WriteLine("1) Legs");
            Console.WriteLine("2) Arms");
            Console.WriteLine("3) Cardio");
            Console.WriteLine("4) Check your BMI");
            Console.WriteLine("5) EXIT");
            

            switch (Console.ReadLine())
            {
                case "1":
                    Legs();
                    return true;
                case "2":
                    Arms();
                    return true;
                case "3":
                    Cardio();
                    return true;
                case "4":
                    checkBMI();
                    return true;
                case "5":
                    Exit();
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the work out you want: ");
            return Console.ReadLine();
        }

        public static void Legs()
        {
            Console.Clear();
            Console.WriteLine("Type which leg work out you would like to do:");
            Console.WriteLine("Squat, Leg Press or Lunges");


            string yourWorkOut = CaptureInput();
            responses.Add(yourWorkOut);
            DisplayResult(yourWorkOut);

        }

        public static void Arms()
        {
            Console.Clear();
            Console.WriteLine("Type which arm work out you would like to do:");
            Console.WriteLine("Bench Press, Bicep Curls or Incline Press");

            string yourWorkOut = CaptureInput();
            responses.Add(yourWorkOut);
            DisplayResult(yourWorkOut);
        }

        public static void Cardio()
        {
            Console.Clear();
            Console.WriteLine("Type which cardio exercise you would like to do:");
            Console.WriteLine("Run, Cycling or Swimming");

            

            string yourWorkOut = CaptureInput();
            responses.Add(yourWorkOut);
            DisplayResult(yourWorkOut);
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine();
            Console.WriteLine($"You chose: {message}");
            if (message.ToLower() == "squat")
            {
                string squatTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\Squat.txt");
                Console.WriteLine("\n" + squatTxt);
            }
            else if (message.ToLower() == "leg press")
            {
                string legPressTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\LegPress.txt");
                Console.WriteLine("\n" + legPressTxt);
            }
            else if (message.ToLower() == "lunges")
            {
                string lungesTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\Lunges.txt");
                Console.WriteLine("\n" + lungesTxt);
            }
            else if (message.ToLower() == "bench press")
            {
                string benchTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\BenchPress.txt");
                Console.WriteLine("\n" + benchTxt);
            }
            else if (message.ToLower() == "bicep curls")
            {
                string bicepsTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\BicepCurls.txt");
                Console.WriteLine("\n" + bicepsTxt);
            }
            else if (message.ToLower() == "incline press")
            {
                string inclineTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\InclinePress.txt");
                Console.WriteLine("\n" + inclineTxt);
            }
            else if (message.ToLower() == "run")
            {
                string runTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Run.txt");
                Console.WriteLine("\n" + runTxt);
            }
            else if (message.ToLower() == "cycling")
            {
                string cyclingTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Cycling.txt");
                Console.WriteLine("\n" + cyclingTxt);
            }
            else if (message.ToLower() == "swimming")
            {
                string swimmingTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Swimming.txt");
                Console.WriteLine("\n" + swimmingTxt);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                
            }


            Console.Write("\nPlease select another work out (enter)");
            Console.ReadLine();
        }


        public static void checkBMI()
        {
            Console.Clear();
            

            double meters = .0254;
            double kG = 0.45;
            Console.WriteLine("Please enter your height in inches:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your weight in pounds:");
            double weight = Convert.ToDouble(Console.ReadLine());
            double weightConversion = kG * weight;
            double heightConversion = meters * height;
            double BMI = weightConversion / (heightConversion * heightConversion);

            Console.Clear();
            Console.WriteLine($"Your BMI: {Math.Round(BMI)}");
            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("You are normal weight.");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }
            Console.WriteLine("\nPress ENTER for main menu.");
            Console.ReadKey();

            



        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Enjoy your work out and have a great day!");
            Console.WriteLine("Here is your work out for " + DateTime.Now.ToLongDateString() + ": ");
            foreach (string x in responses)
            {
                Console.WriteLine();
                Console.WriteLine("-" + x.ToUpper());
                Console.WriteLine();

                
            }
                    


        }
    }
}
