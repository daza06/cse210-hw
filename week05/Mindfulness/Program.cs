using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Listing Activity");
            Console.WriteLine(" 3. Reflecting Activity");
            Console.WriteLine(" 4. Exit");
            Console.Write("\nSelect a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }

            Console.Write("\nPress Enter to continue... ");
            Console.ReadLine();
        }
    }
}