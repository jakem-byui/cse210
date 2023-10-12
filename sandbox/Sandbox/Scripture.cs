using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private string fullScripture;
    private List<Word> words;
    private int hiddenWordCount;

    public Scripture(string reference, string text)
    {
        ScriptureReference = new ScriptureReference(reference);
        fullScripture = $"{reference}: {text}";

        // Split the scripture text into words
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        hiddenWordCount = 0;
    }

    public ScriptureReference ScriptureReference { get; }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(fullScripture);
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        // Select only those words that are not already hidden
        var availableWords = words.Where(word => !word.IsHidden).ToList();

        if (availableWords.Count == 0)
        {
            Console.WriteLine("All words are hidden. Press Enter to exit.");
            return;
        }

        // Hide a few random words
        int wordsToHideCount = random.Next(1, Math.Min(availableWords.Count, 4)); // Hide 1 to 4 words
        for (int i = 0; i < wordsToHideCount; i++)
        {
            int indexToHide = random.Next(availableWords.Count);
            availableWords[indexToHide].IsHidden = true;
            hiddenWordCount++;
        }

        // Update the full scripture with hidden words
        string updatedScripture = string.Join(' ', words.Select(word => word.Display()));

        // Display the updated scripture
        Console.Clear();
        Console.WriteLine($"{ScriptureReference.Reference}: {updatedScripture}");
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
    }

    public bool AllWordsHidden()
    {
        return hiddenWordCount == words.Count;
    }
}
