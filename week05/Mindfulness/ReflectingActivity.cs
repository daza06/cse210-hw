public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something really difficult.",
        "Think of a time you surprised yourself.",
        "Think of a time you felt completely at peace.",
        "Think of a time you overcame a fear."
    };

    private List<string> _questions = new List<string>
    {
        "What is your favorite thing about this experience?",
        "How did you feel when it was complete?",
        "What in my life would my younger self be amazed by?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity helps you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"\n{question} ");
            ShowSpinner(10);
        }

        EndActivity();
    }
}