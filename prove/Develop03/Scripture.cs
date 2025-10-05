using System;
using System.Collections.Generic;

public class Scripture
{
    //setting up the private references
    private Reference _reference;
    private List<Word> _theText = new List<Word>();

    
    //this splits the string into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string TheText in text.Split(' '))
        {
            _theText.Add(new Word(TheText));
        }

    }
    //this is able to display the words and adds a space
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

    //this one is also a strech. It hides the words, and makes sure only words that are not hidden are selected
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
    this is the old HideRandomWords

    Random rand = new Random();
    for (int i = 0; i < TheOneThatHides; i++)
    {
        int index = rand.Next(_theText.Count);
        _theText[index].Hide();
    }

*/

    // This checks to see if everything is hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _theText)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }


}
