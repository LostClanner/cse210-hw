using System;



class Word()
{
    private string _theText;
    private bool _isHidden;


    public Word(string TheText)
    {
        _theText = TheText;
        _isHidden = false;

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if _isHidden
        {
            return "______";
        }
        else
        {
            return _theText;
        }
    }


}