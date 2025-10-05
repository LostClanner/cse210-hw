using System;


class Word
{

    //setting up our private classes
    private string _theText;
    private bool _isHidden;


    //This turns that info into data that can be used
    public Word(string TheText)
    {
        _theText = TheText;
        _isHidden = false;

    }

    //hides words
    public void Hide()
    {
        _isHidden = true;
    }

    //this displayed text wither it be hidden or visable
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "______";
        }
        else
        {
            return _theText;
        }
    }


    //I needed this because without it it was broken. It allows things to see what is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    


}