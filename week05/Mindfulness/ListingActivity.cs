public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month?",
        "What do I want more of in my life?",
        "What do I take for granted every day?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        EndActivity();
    }
}