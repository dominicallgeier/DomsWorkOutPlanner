using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace DomsWorkOutPlanner
{
    
    class Program
    {
        //my List of user selected workouts to display at the end
        static List<string> responses = new List<string>();
        
        
        


        static void Main(string[] args)
        {
            /* Master Loop
             show menu until user tells it exit which would make it false, and then exiting. 
            This creates a master loop for the user to go back and add multiple work outs to their planner */
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************");

            Console.WriteLine("Welcome to Dominic's Fitness Planner!");

            Console.WriteLine("*************************************");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("*************************************");

            Console.WriteLine("Create your own work out!");

            Console.WriteLine("*************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Please select a category you want to work out:");
            Console.WriteLine("1) Legs");
            Console.WriteLine("2) Arms");
            Console.WriteLine("3) Cardio");
            Console.WriteLine("4) Check your BMI");
            Console.WriteLine("5) EXIT");


            switch (Console.ReadLine())
            {
                //allowing my user to have categories to choose from on the menu
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
            //this is returning the workout the user wants
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.Write("Enter the work out you want: ");
            Console.ResetColor();
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
            //reading from a txt file

            Console.WriteLine();
            Console.WriteLine($"You chose: {message}");
            if (message.ToLower() == "squat")
            {
                var squatTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Legs\Squat.txt";
                string squatTxt = System.IO.File.ReadAllText(squatTxtFileName);
               
                Console.WriteLine("\n" + squatTxt);
            }
            else if (message.ToLower() == "leg press")
            {
                var legPressTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Legs\LegPress.txt";
                string legPressTxt = System.IO.File.ReadAllText(legPressTxtFileName);
                Console.WriteLine("\n" + legPressTxt);
            }
            else if (message.ToLower() == "lunges")
            {
                var lungesTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Legs\Lunges.txt";
                string lungesTxt = System.IO.File.ReadAllText(lungesTxtFileName);
                Console.WriteLine("\n" + lungesTxt);
            }
            else if (message.ToLower() == "bench press")
            {
                var benchTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Arms\BenchPress.txt";
                string benchTxt = System.IO.File.ReadAllText(benchTxtFileName);
                Console.WriteLine("\n" + benchTxt);
            }
            else if (message.ToLower() == "bicep curls")
            {
                var bicepTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Arms\BicepCurls.txt";
                string bicepsTxt = System.IO.File.ReadAllText(bicepTxtFileName);
                Console.WriteLine("\n" + bicepsTxt);
            }
            else if (message.ToLower() == "incline press")
            {
                var inclineTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Arms\InclinePress.txt";
                string inclineTxt = System.IO.File.ReadAllText(inclineTxtFileName);
                Console.WriteLine("\n" + inclineTxt);
            }
            else if (message.ToLower() == "run")
            {
                var runTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Cardio\Run.txt";
                string runTxt = System.IO.File.ReadAllText(runTxtFileName);
                Console.WriteLine("\n" + runTxt);
            }
            else if (message.ToLower() == "cycling")
            {
                var cyclingTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Cardio\Cycling.txt";
                string cyclingTxt = System.IO.File.ReadAllText(cyclingTxtFileName);
                Console.WriteLine("\n" + cyclingTxt);
            }
            else if (message.ToLower() == "swimming")
            {
                var swimmingTxtFileName = System.IO.Directory.GetCurrentDirectory() + @"\Txt\Cardio\Swimming.txt";
                string swimmingTxt = System.IO.File.ReadAllText(swimmingTxtFileName);
                Console.WriteLine("\n" + swimmingTxt);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                
            }


            Console.Write("\nPlease select another work out (enter)");
            Console.ReadLine();
        }

        //BMI calculation. going from inches/pounds to meters/kG
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are underweight.");
                Console.ResetColor();
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are normal weight.");
                Console.ResetColor();
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are overweight.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are obese.");
                Console.ResetColor();
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

            Console.WriteLine();
            Quote();



        }

        public static void Quote()
        {
            var random = new Random();
            List<string> quotes = new List<string>(5);
            quotes.Add("“Energy & persistence conquer all things.” – Benjamin Franklin");
            quotes.Add("“Make each day your masterpiece.” – John Wooden");
            quotes.Add("“Life is like riding a bicycle. To keep your balance, you must keep moving.” – Albert Einstein");
            quotes.Add("“Tough times never last, but tough people do.” – Dr. Robert Schuller");
            quotes.Add("“Don’t wait, the time will never be just right.” – Napoleon Hill");

            int i = random.Next(quotes.Count);
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(quotes[i]);
            Console.ResetColor();


        }
    }

    
    
        
    
}

