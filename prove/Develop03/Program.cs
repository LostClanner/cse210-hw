using System;

class Program
{
    static void Main(string[] args)
    {

        //this creates our scriptures as things we can use
        Reference refer1 = new Reference("John", 3, 16);
        Scripture TheText1 = new Scripture (refer1, "For God so loved the world, that he gave his only begotten Son.");

        Reference refer2 = new Reference("Mormon", 9, 31);
        Scripture TheText2 = new Scripture (refer2, "Condemn me not because of mine imperfection, neither my father, because of his imperfection, neither them who have written before him; but rather give thanks unto God that he hath made manifest unto you our imperfections, that ye may learn to be more wise than we have been.");

        Reference refer3 = new Reference("Alma", 32, 21);
        Scripture TheText3 = new Scripture (refer3, "And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");

        Reference refer4 = new Reference("Matthew", 3, 14, 17);
        Scripture TheText4 = new Scripture (refer4, "14 But John forbad him, saying, I have need to be baptized of thee, and comest thou to me? And Jesus answering said unto him, Suffer it to be so now: for thus it becometh us to fulfil all righteousness. Then he suffered him. And Jesus, when he was baptized, went up straightway out of the water: and, lo, the heavens were opened unto him, and he saw the Spirit of God descending like a dove, and lighting upon him: And lo a voice from heaven, saying, This is my beloved Son, in whom I am well pleased.");


        //this is the start of the program, its a choice switch
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("please select a scripture to memorize:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Mormon 9:31");
        Console.WriteLine("3. Alma 32:21");
        Console.WriteLine("4. Matthew 3:14-17");
        Console.Write("Enter the number of your choice: ");
        string choice = Console.ReadLine();
        Scripture scripture;
        switch (choice)
        {
            case "1":
                scripture = TheText1;
                break;
            case "2":
                scripture = TheText2;
                break;
            case "3":
                scripture = TheText3;
                break;
            case "4":
                scripture = TheText4;
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to John 3:16.");
                scripture = TheText1;
                break;
        }


        //while look to keep it going
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter for more to disapear, enter 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

    }
}
