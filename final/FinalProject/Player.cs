using System;



public class Player
{
    private List<Card> _playerHand = new List<Card>();

    public Player()
    {
        
    }

    public void PlayCard()
    {

    }

    public void AddCardToHand(Card card)
    {
        _playerHand.Add(card);
    }

    public void GetHand()
    {
        foreach (Card card in _playerHand)
        {
            Console.Write($"{card.ToString} ");
        }
    }
    
}