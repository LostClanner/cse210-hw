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

    public GetDisplayText()
    {
        if (int Reference._verseEnd = 0){
            return _book, _chapter, _startverse
        }
        else {

            return return _book, _chapter, _startverse, _verseEnd
        }


    }
}