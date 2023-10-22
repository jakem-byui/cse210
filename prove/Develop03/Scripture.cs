using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"Reference: {_reference}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetText()} ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

        if (unhiddenWords.Count > 0)
        {
            int randomIndex = random.Next(0, unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }
}