class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator(List<string> _prompts)
    {
        prompts = _prompts;
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
