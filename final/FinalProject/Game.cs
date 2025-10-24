using System;
using System.Collections.Generic;
using System.Linq;


public class Game
{
    private Deck _deck = new Deck();
    private List<Player> _players = new List<Player>();
    private List<Card> _discardPile = new List<Card>();
    private int _currentPlayerPosition = 0;
    private bool _isReversed = false;
    private bool _hasPlayerWon = false;
    private Card TopOfDiscardPile => _discardPile.Last();


    public Game()
    {

    }

    public void StartGame(int playerCount, int startingHandSize = 7/*how many decks you are wanting to play with*/)
    {
        while (playerCount > 0)
        {
            _players.Add(new Player());
            playerCount--;
        }

        _deck.MakeNewDeck();    

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


    public void PlayerPlayCard(Player currentPlayer, Card cardToPlay)
    {
        currentPlayer.PlayCard(cardToPlay);
        _discardPile.Add(cardToPlay);

        Console.WriteLine();
        Console.WriteLine($"You played |{cardToPlay.ToString()}|");

        //HandelCardEffect();

    }

    public void PlayerDrawCard(Player currentPlayer)
    {
        int deckCardAmount = _deck.GetDeckCount();

        if (deckCardAmount == 0)
        {
            foreach(Card card in _discardPile)
            {
                _deck.AddToDeck(card);
            }
        }

        Card drawnCard = _deck.DrawCard();
        currentPlayer.AddCardToHand(drawnCard);

        Console.WriteLine();
        Console.WriteLine($"You drew: |{drawnCard.ToString()}|");

        //add something if they are able to play it imideietly

    }

    // public void HandelCardEffect()
    // {

    // }

    private void TakeTurn()
    {
        Player currentPlayer = _players[_currentPlayerPosition];
        // Console.Clear(); Removed for testing purpuses

        Console.WriteLine($"----Player {_currentPlayerPosition + 1}----");
        Console.WriteLine($"top card is: {TopOfDiscardPile.ToString()}");

        PlayerDisplayHand(currentPlayer);
        


        Card cardToPlay = currentPlayer.FindPlayableCard(TopOfDiscardPile);

        if (cardToPlay == null)
        {
            Console.WriteLine("You have nothing to play, drawing card");
            PlayerDrawCard(currentPlayer);
        }
        else
        {
            PlayerPlayCard(currentPlayer, cardToPlay);
        }

        if (currentPlayer.GetHand().Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Player {_currentPlayerPosition + 1} Wins!");
            _hasPlayerWon = true;
            return;
        }


        NextTurn();
        
    }





    public void Run()
    {
        Console.WriteLine("Starting a new game");
        Console.WriteLine();
        StartGame(2);

        while (!_hasPlayerWon)
        {
            TakeTurn();
            // Console.ReadLine();
        }

        Console.WriteLine("Game Over");
        Console.Write("press enter to close: ");
        Console.ReadLine();
    }


    private void PlayerDisplayHand(Player currentPlayer)
    {
        List<Card> playerHand = currentPlayer.GetHand();
        Console.WriteLine("Your hand:");

        foreach (Card card in playerHand)
        {
            Console.Write($"|{card}| ");
        }
    }

}