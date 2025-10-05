using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _theText = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string TheText in text.Split(' '))
        {
            _theText.Add(new Word(TheText));
        }

    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string theActualStricpture = "";

        foreach (Word TheText in _theText)
        {
            theActualStricpture += TheText.GetDisplayText() + " ";
        }
        return referenceText + " " + theActualStricpture.Trim();

    }


    public void HideRandomWords(int TheOneThatHides)
    {
        List<int> visibleText = new List<int>(); ;
        for (int i = 0; i < _theText.Count; i++)
        {
            if (!_theText[i].IsHidden())
            {
                visibleText.Add(i);
            }
        }

        if (visibleText.Count == 0) return;

        var rando = new Random();
        int needToHide = Math.Min(TheOneThatHides, visibleText.Count);

        for (int i = 0; i < needToHide; i++)
        {
            int pick = rando.Next(visibleText.Count);
            int actualIndex = visibleText[pick];
            _theText[actualIndex].Hide();
            visibleText.RemoveAt(pick); 
        }


    }



/*
    Random rand = new Random();
    for (int i = 0; i < TheOneThatHides; i++)
    {
        int index = rand.Next(_theText.Count);
        _theText[index].Hide();
    }

*/


    public bool IsCompletelyHidden()
    {
        foreach (Word word in _theText)
        {
            if (!word.IsHidden())  // if even one word is visible
            {
                return false;
            }
        }

        return true;
    }


}



//We will work on this one later.