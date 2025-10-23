using System;
using System.Collections.Generic;
using System.Linq;


public class Game
{
    private Deck _deck;
    private List<Player> _players = new List<Player>();
    private List<Card> _discardPile = new List<Card>();
    private int _currentPlayerPosition = 0;
    private bool _isReversed = false;
    private bool _hasPlayerWon = false;
    private Card TopofDiscardPile => _discardPile.Last();


    public Game()
    {
        _deck = new Deck();
    }

    public void StartGame(int playerCount, int startingHandSize = 7/*how many decks you are wanting to play with*/)
    {
        while (playerCount > 0)
        {
            _players.Add(new Player());
            playerCount--;

        }
        int i = 0;

        while (i < startingHandSize)
        {
            foreach(Player player in _players)
            {
                player.AddCardToHand(_deck.DrawCard());
            }
            i++;
        }
        _discardPile.Add(_deck.DrawCard());
        //What happends when a special card is drawn?


    }

    private void NextTurn()
    {
        if (_isReversed)
        {
            _currentPlayerPosition--;
        }
        else
        {
            _currentPlayerPosition++;
        }

        if (_currentPlayerPosition >= _players.Count)
        {
            _currentPlayerPosition = 0;
        }
        if(_currentPlayerPosition < 0)
        {
            _currentPlayerPosition = _players.Count - 1;
        }
    }


    public void PlayerPlayCard()
    {
        Player currentPlayer = _players[_currentPlayerPosition];
        currentPlayer.GetHand();
        // currentPlayer.PlayCard();
       

    }

    public void PlayerDrawCard(Deck d1)
    {
        Player currentPlayer = _players[_currentPlayerPosition];
        Card drawnCard = d1.DrawCard();
        currentPlayer.AddCardToHand(drawnCard);
        currentPlayer.GetHand();

    }

    public void HandelCardEffect()
    {

    }
    




    public void Run()
    {
        Console.WriteLine("Starting a new game");
        StartGame(4);

        while (!_hasPlayerWon)
        {
            
        }

        Console.WriteLine("Game Over");
        Console.Write("press enter to close: ");
        Console.ReadLine();
    }

}