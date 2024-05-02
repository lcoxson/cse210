public class Entry
{
    public DateTime currentDate = DateTime.Now;
    public string _promptText = PromptGenerator.GetRandomPrompt();
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine(currentDate.ToShortDateString());
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}