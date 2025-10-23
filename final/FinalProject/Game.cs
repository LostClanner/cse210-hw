using System;


public class Game
{
    private Deck _deck;
    private List<Player> _players = new List<Player>();
    private List<Card> _discardPile = new List<Card>();
    private int _currentPlayer = 0;
    private bool _isReversed = false;



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

    private void NextPlayer()
    {
        if (_isReversed)
        {
            _currentPlayer++;
        }
        else
        {
            _currentPlayer--;
        }

        if (_currentPlayer >= _players.Count)
        {
            _currentPlayer = 0;
        }
        if(_currentPlayer <= _players.Count)
        {
            _currentPlayer = _players.Count - 1;
        }
    }

    public void NextTurn()
    {

        // if (player.CanPlayCard)
        // {
        //     PlayerPlayCard();
        // }
        // else
        // {
        //     PlayerDrawCard();
        // }
                                    //Something like this is needed--

        // if (_isReversed)
        // {
        //     Player - 1
        // }
        // else
        // {
        //     Player + 1
        // }

    }

    public void PlayerPlayCard()
    {
        Player currentPlayer = _players[_currentPlayer];
        currentPlayer.GetHand();
        /*P1*/.PlayCard();
       

    }

    public void PlayerDrawCard()
    {
        /*P1*/.GetHand();
        /*P1*/.AddCardToHand();
    }

    public void HandelCardEffect()
    {
        
    }

}