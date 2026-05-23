public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "If you could change something about your day what would it be?",
        "What was your favorite meal today and why?",
        "How did you see the hand of the Lord in your life today?",
        "Who did you spend the most time with today and what did you do?",
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}