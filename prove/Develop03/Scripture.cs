using System;

public class Scripture()
{
    public class _john316()
    {
        private string text = ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        private Reference reference = new Reference();
        private string book = "John";
        private int chapter = 3;
        private int verseStart = 16;
        private int verseEnd = 16;

        public string GetText()
        {
            return text;
        }

        public string GetReference()
        {
            return reference._reference(book, chapter, verseStart, verseEnd);
        }
    }

    public class _mormon931()
    {
        private string text = ("31 Condemn me not because of mine imperfection, neither my father, because of his imperfection, neither them who have written before him; but rather give thanks unto God that he hath made manifest unto you our imperfections, that ye may learn to be more wise than we have been.");
        private Reference reference = new Reference();
        private string book = "Mormon";
        private int chapter = 9;
        private int verseStart = 31;
        private int verseEnd = 31;

        public string GetText()
        {
            return text;
        }

        public string GetReference()
        {
            return reference._reference(book, chapter, verseStart, verseEnd);
        }
    }



}