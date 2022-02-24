using System;

namespace DomsWorkOutPlanner
{
    class Program
    {
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
            Console.WriteLine();
            Console.WriteLine("Welcome to Dominic's Fitness Planner!");
            Console.WriteLine();
            Console.WriteLine("*************************************");
            
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("Create your own work out!");
            Console.WriteLine();
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("Please select a category you want to work out:");
            Console.WriteLine("1) Legs");
            Console.WriteLine("2) Arms");
            Console.WriteLine("3) Cardio");
            Console.WriteLine("4) EXIT");
            

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

        private static void Legs()
        {
            Console.Clear();
            Console.WriteLine("Type which leg work out you would like to do:");
            Console.WriteLine("Squat, Leg Press or Lunges");

            char[] charArray = CaptureInput().ToCharArray();
            
            DisplayResult(String.Concat(charArray));
        }

        private static void Arms()
        {
            Console.Clear();
            Console.WriteLine("Type which arm work out you would like to do:");
            Console.WriteLine("Bench Press, Bicep Curls or Incline Press");

            char[] charArray = CaptureInput().ToCharArray();

            DisplayResult(String.Concat(charArray));
        }

        private static void Cardio()
        {
            Console.Clear();
            Console.WriteLine("Type which cardio exercise you would like to do:");
            Console.WriteLine("Run, Cycling or Swimming");

            char[] charArray = CaptureInput().ToCharArray();

            DisplayResult(String.Concat(charArray));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYou chose: {message}");
            if (message.ToLower() == "squat")
            {
                string squatTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\Squat.txt");
                Console.WriteLine(squatTxt);
            }
            else if (message.ToLower() == "leg press")
            {
                string legPressTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\LegPress.txt");
                Console.WriteLine(legPressTxt);
            }
            else if (message.ToLower() == "lunges")
            {
                string lungesTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Legs\Lunges.txt");
                Console.WriteLine(lungesTxt);
            }
            else if (message.ToLower() == "bench press")
            {
                string benchTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\BenchPress.txt");
                Console.WriteLine(benchTxt);
            }
            else if (message.ToLower() == "bicep curls")
            {
                string bicepsTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\BicepCurls.txt");
                Console.WriteLine(bicepsTxt);
            }
            else if (message.ToLower() == "incline press")
            {
                string inclineTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Arms\InclinePress.txt");
                Console.WriteLine(inclineTxt);
            }
            else if (message.ToLower() == "run")
            {
                string runTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Run.txt");
                Console.WriteLine(runTxt);
            }
            else if (message.ToLower() == "cycling")
            {
                string cyclingTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Cycling.txt");
                Console.WriteLine(cyclingTxt);
            }
            else if (message.ToLower() == "swimming")
            {
                string swimmingTxt = System.IO.File.ReadAllText(@"C:\WorkOutTxt\Cardio\Swimming.txt");
                Console.WriteLine(swimmingTxt);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }


            Console.Write("\r\nPlease select another work out (enter)");
            Console.ReadLine();
        }

        private static void Exit()
        {
            Console.WriteLine("Enjoy your work out and have a great day!");
            Console.WriteLine("Here is your work out for " + DateTime.Now.ToLongDateString() + ": ");
            
        }
    }
}
