using System;
using System.Collections.Generic;
 
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random();
 
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
 
        string[] rawWords = text.Split(' ');
        foreach (string rawWord in rawWords)
        {
            if (rawWord.Length > 0)
            {
                _words.Add(new Word(rawWord));
            }
        }
    }
 
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = GetVisibleWords();
 
        int amountToHide = numberToHide;
        if (amountToHide > visibleWords.Count)
        {
            amountToHide = visibleWords.Count;
        }
 
        for (int i = 0; i < amountToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
 
    public bool IsCompletelyHidden()
    {
        return GetVisibleWords().Count == 0;
    }
 
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n\n";
 
        for (int i = 0; i < _words.Count; i++)
        {
            displayText = displayText + _words[i].GetDisplayText();
 
            if (i < _words.Count - 1)
            {
                displayText = displayText + " ";
            }
        }
 
        return displayText;
    }
 
    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
 
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
 
        return visibleWords;
    }
}