using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
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

    public void StartGame(int playerCount, int startingHandSize = 7)
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
            foreach (Player player in _players)
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
        if (_currentPlayerPosition < 0)
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
    }

    public void PlayerDrawCard(Player currentPlayer)
    {
        CheckDeck();
        Card drawnCard = _deck.DrawCard();
        currentPlayer.AddCardToHand(drawnCard);
        Console.WriteLine();
        Console.WriteLine($"You drew: |{drawnCard.ToString()}|");

        if (drawnCard.CanPlayCard(TopOfDiscardPile.Color, TopOfDiscardPile.Value))
        {
            Console.WriteLine("And played it immediately!");
            PlayerPlayCard(currentPlayer, drawnCard);
            drawnCard.SpecialCardEffect(this); //Need a better way to handle special cards
        }
    }

    private void CheckDeck()
    {
        if (_deck.GetDeckCount() == 0)
        {
            Console.WriteLine("Deck empty shuffling deck");
            Card topCard = TopOfDiscardPile; //Getting top of the discard to keep it
            _discardPile.Remove(topCard);

            foreach (Card card in _discardPile)
            {
                _deck.AddToDeck(card);
            }
            _discardPile.Clear();
            _discardPile.Add(topCard);
            _deck.ShuffleDeck();
        }
    }


    private void TakeTurn()
    {
        Player currentPlayer = _players[_currentPlayerPosition];
        // Console.Clear(); Removed for testing purpuses

        Console.WriteLine($"----Player {_currentPlayerPosition + 1}----");
        Console.WriteLine($"top card is: {TopOfDiscardPile.ToString()}");
        Console.WriteLine();

        currentPlayer.DisplayHand();
        Console.WriteLine();

        bool turnWasAffectedByCard = false;

        while (true)
        {
            Console.WriteLine("Pick a card to play or enter '0' to draw");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 0)
                {
                    PlayerDrawCard(currentPlayer);
                    // NextTurn();
                    break;
                }
                int cardIndex = choice - 1;
            
                Card chosenCard = currentPlayer.GetCardFromHand(cardIndex);

                if (chosenCard == null)
                {
                    Console.WriteLine("You are unable to play that card");
                }
                else if (chosenCard.CanPlayCard(TopOfDiscardPile.Color, TopOfDiscardPile.Value))
                {
                    PlayerPlayCard(currentPlayer, chosenCard);
                    // NextTurn();
                    turnWasAffectedByCard = chosenCard.SpecialCardEffect(this);
                    break;

                }
                else
                {
                    Console.WriteLine($"You can't play {chosenCard} it is not a match");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            if (currentPlayer.GetHand().Count == 0)
            {
                Console.WriteLine($"Player {_currentPlayerPosition + 1} has Won!");
                _hasPlayerWon = true;
                return;
            }
            if (!turnWasAffectedByCard)
            {
                NextTurn();
            }


        }

    }

    public void Run()
    {
        Console.WriteLine("Starting a new game");
        Console.WriteLine();
        StartGame(2);

        while (!_hasPlayerWon)
        {
            TakeTurn();
        }

        Console.WriteLine("Game Over");
        Console.Write("press enter to close: ");
        Console.ReadLine();
    }




    //------The cards abilities------
    public void SkipNextPlayer()
    {
        Console.WriteLine("You skipped the next player");
        NextTurn();
    }

    public void ReverseDirection()
    {
        Console.WriteLine("You reversed the direction");
        _isReversed = !_isReversed;

    }

    public void ForceToDraw(int count)
    {
        Player nextPlayer = GetNextPlayer();
        Console.WriteLine($"Player {GetNextPlayerIndex() + 1} draws {count} and is skipped!");
        for (int i = 0; i < count; i++)
        {
            CheckDeck();
            nextPlayer.AddCardToHand(_deck.DrawCard());
        }
        NextTurn();
    }

    public CardColor ChangeColor()
    {
        while (true)
        {
            Console.WriteLine("Choose the new color: 1.Red 2.Blue 3.Green 4.Yellow");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": return CardColor.Red;
                case "2": return CardColor.Blue;
                case "3": return CardColor.Green;
                case "4": return CardColor.Yellow;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }

    }


    private int GetNextPlayerIndex()
    {
        int nextIndex = _currentPlayerPosition;
        if (_isReversed)
        {
            nextIndex--;
        }
        else
        {
            nextIndex++;
        }

        if (nextIndex >= _players.Count)
        {
            nextIndex = 0;
        }
        if (nextIndex < 0)
        {
            nextIndex = _players.Count - 1;
        }

        return nextIndex;
    }

    private Player GetNextPlayer()
    {
        int nextIndex = GetNextPlayerIndex();
        return _players[nextIndex];
    }


}

















        // if (cardToPlay == null)
        // {
        //     Console.WriteLine("You have nothing to play, drawing card");
        //     PlayerDrawCard(currentPlayer);
        // }
        // else
        // {
        //     // int cardOptions = cardToPlay.Count()
        //     // PlayerPlayCard(currentPlayer, cardToPlay);
        // }

        // if (currentPlayer.GetHand().Count == 0)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine($"Player {_currentPlayerPosition + 1} Wins!");
        //     _hasPlayerWon = true;
        //     return;
        // }


        // NextTurn();