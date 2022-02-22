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
            Console.WriteLine("Welcome to Dominic's Fitness Planner!");
            Console.WriteLine("Create your own work out!");
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
            Console.Write("\r\nPlease select another work out (enter)");
            Console.ReadLine();
        }

        private static void Exit()
        {
            Console.WriteLine("Enjoy your work out and have a great day!");
            Console.WriteLine("Here is your work out: ");
            
        }
    }
}
