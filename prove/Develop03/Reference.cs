using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;


    public Reference(string Book, int Chapter, int VerseStart)
    {
        _book = Book;
        _chapter = Chapter;
        _verseStart = VerseStart;
        _verseEnd = 0;
    }

    public Reference(string Book, int Chapter, int VerseStart, int VerseEnd)
    {
        _book = Book;
        _chapter = Chapter;
        _verseStart = VerseStart;
        _verseEnd = VerseEnd;
    }


    //Need to fix this one
    //we want to return these things, but what feilds need to be put in to make it work correctly?
    public string GetDisplayText()
    {
        if (_verseEnd == 0) //== in c# we are not in python anymore! had trouble with that one!
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }

    }
}