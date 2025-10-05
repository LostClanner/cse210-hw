using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Reference
{
    //setting up private classes
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;


    //this makes the references
    public Reference(string Book, int Chapter, int VerseStart)
    {
        _book = Book;
        _chapter = Chapter;
        _verseStart = VerseStart;
        _verseEnd = 0;
    }
    //this is the same, but handles multipul verses
    public Reference(string Book, int Chapter, int VerseStart, int VerseEnd)
    {
        _book = Book;
        _chapter = Chapter;
        _verseStart = VerseStart;
        _verseEnd = VerseEnd;
    }


    //this one displayes the reference cleanly
    public string GetDisplayText()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }

    }
}