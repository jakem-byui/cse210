public static class PromptGenerator
{
    private static List<string> prompts = new List<string>
    {
        // Lesson suggested prompts
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // Other journal prompts! :)
        "What made you happy today?",
        "Describe a challenging situation you faced today and how you handled it.",
        "Write about a person you interacted with today and the impact they had on you.",
        "Discuss a goal you have for the upcoming week and how you plan to achieve it.",
        "Reflect on a mistake you made today and what you learned from it."
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}