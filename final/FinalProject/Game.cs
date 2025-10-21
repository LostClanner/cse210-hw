using System;


public class Game
{
    private Deck _deck;
    private List<Player> _players = new List<Player>();
    private List<Card> _discardPile = new List<Card>();
    // private Player _currentPlayer;
    private bool _isReversed;



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
        /*P1*/.GetHand();
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