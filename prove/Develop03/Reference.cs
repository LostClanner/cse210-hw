using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Reference
{
    /*
    private string Book = null;
    private int Chapter = 0;
    private int VerseStart = 0;
    private int VerseEnd = 0;
    private string Text = null;


    */
    //reference book chapter verse

    public string _reference(int UserInput, string Book, int Chapter, int VerseStart, int VerseEnd, string Text)
    {
        string _book = Book;
        string _text = Text;
        int _chapter = Chapter;
        int _verseStart = VerseStart;
        int _verseEnd = VerseEnd;
        int 

        if (VerseEnd > VerseStart)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}:{_text}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart},{_text}";
        }


    }
    //reference book chapter versestart verse end
    //to string string
}