using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter a filename: ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
                Console.WriteLine("Your file is saved!");
                Console.WriteLine();

            }
            else if (choice == 4)
            {
                Console.Write("Enter a filename: ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
                Console.WriteLine("Your journal loaded!");
                Console.WriteLine();

            }
            else if (choice == 5)
            {
                Console.WriteLine("Thanks for using the journal. Goodbye!");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Invalid choice. Try again!");
                Console.WriteLine();

            }

        }
    }
}