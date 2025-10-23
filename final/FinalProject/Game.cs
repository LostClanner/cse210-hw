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
    private Card => _discardPile.Last();


    public Game()
    {

    }

    public void StartGame(int players/*, int decks*/)
    {
        while (players > 0)
        {
            _players.Add(new Player());
        }
        // while (decks > 0)
        // {

        // }


        //Someway to give all the players thier starting cards



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
    



    //Testing purposes only

    public void Run()
    {
        Deck d1 = new Deck();
        d1.MakeNewDeck();
        d1.DisplayDeck();
    }

}