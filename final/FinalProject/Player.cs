using System;



public class Player
{
    private List<Card> _playerHand = new List<Card>();

    public Player()
    {
        
    }

    public void PlayCard(Card card)
    {
        _playerHand.Remove(card);
    }

    public void AddCardToHand(Card card, int amount)
    {
        while (amount > 0)
        {
            _playerHand.Add(card);
        }
    }


    //This needs a lot of work, dont forget to fix it
    public void GetHand()
    {
        foreach (Card card in _playerHand)
        {
            if (card.CanPlayCard(CardColor.Yellow, CardValue.Seven)) // this well need to be changed before the final implamentaion
            {
                Console.WriteLine("Playable cards");
                Console.Write($"{card.ToString} ");

            }
            else
            {
                Console.WriteLine("Cards unable to be played");
                Console.Write($"{card.ToString} ");
            }

        }
    }
    
}