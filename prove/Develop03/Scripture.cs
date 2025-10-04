using System;

public class Scripture()
{
    private Reference _reference;
    private new List<_theText>;

    public HiddenMaker(Reference reference, string TheText)
    {
        reference = _reference;
        TheText = new List<_theText>();

        foreach (string TheText in text.split(""))
        {
            _theText.Add(new Word(TheText));
        }

    }

    public string GetDisplayText()
    {
        string ReferenceText = _reference.GetDisplayText;
        string TheActualStricpture = "";

        foreach (Word TheText in _theText)
        {
            TheActualStricpture += TheText.GetDisplayText() + " ";
        }
        return ReferenceText + " " + TheActualStricpture.Trim();

    }


    public void HideRandomWords(int TheOneThatHides)
    {
    Random rand = new Random();
    for (int i = 0; i < TheOneThatHides; i++)
    {
        int index = rand.Next(_theText.Count);
        _theText[index].Hide();
    }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _theText)
        {
            if (!Word._isHidden())  // if even one word is visible
            {
                return false;
            }
        }

        return true;
    }


}



//We will work on this one later.