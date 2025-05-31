using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < count)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }

            if (IsCompletelyHidden()) break;
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
}
