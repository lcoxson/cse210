Random chooseRandom = new Random();

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "How did I see the hand of the Lord in my life today? ",
        "What am I most grateful for today? ",
        "How did I chose to turn to Christ today? ",
        "What am I excited about right now? ",
        "What goals did I work toward today? ",
        "How did I serve the Lord today, and how can I serve Him tomorrow? ",
        "What did I learn from the scriptures today?"
    };

    public string GetRandomPrompt()
    {
        int index = chooseRandom.next(_prompts.Count);
        return _prompts[index];
    }
}