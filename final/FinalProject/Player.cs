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

    public void AddCardToHand(Card card)
    {

        _playerHand.Add(card);

    }

    public Card GetCardFromHand(int index)
    {
        if (index >= 0 && index < _playerHand.Count)
        {
            return _playerHand[index];
        }
        else
        {
            return null;
        }
    }

    public List<Card> GetHand()
    {
        return _playerHand;
    }

    public void DisplayHand()
    {
        Console.WriteLine("Your hand:");
        int i = 1;
        foreach (Card card in _playerHand)
        {
            Console.Write($"Card {i} |{card}| ");
            i++;
        }
        Console.WriteLine();
    
    }


}