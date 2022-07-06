using System;
using System.Collections.Generic;

namespace unit02_hilo
{
    class Director
    {

        public Director(){} 

        public void playGame()
        {

        string playAgain = "y";
        int randomCard()
        {
        Random rnd = new Random();
        int algo = rnd.Next(1,14); 
        return algo;
        }

        Dealer first_Card = new Dealer();
        first_Card._card1 = randomCard();
        Player score = new Player();
        first_Card._score = score._score;
        first_Card._card2 = randomCard();
        score.space();
        Console.WriteLine($"The card is: {first_Card._card1}");
        Console.WriteLine($"Higher or lower? [h/l]"); 
        first_Card._playersbet = Console.ReadLine();
        Console.WriteLine($"Next card was: {first_Card._card2}");
        first_Card.points_decision();
        Console.WriteLine($"Your score is: {first_Card._score}");
        score._score = first_Card._score;
        Console.WriteLine($"Play again? [y/n] ");
        playAgain = Console.ReadLine();

        while (playAgain == "y" && score._score > 0){
        first_Card._card1 = first_Card._card2;
        score.space();
        Console.WriteLine($"The card is: {first_Card._card1}");
        Console.WriteLine($"Higher or lower? [h/l]");
        first_Card._playersbet = Console.ReadLine();
        first_Card._card2 = randomCard();
        Console.WriteLine($"Next card was: {first_Card._card2}");
        first_Card.points_decision();
        Console.WriteLine($"Your score is: {first_Card._score}");
        score._score = first_Card._score;
        Console.WriteLine($"Play again? [y/n] ");
        playAgain = Console.ReadLine();
        }
    }
    
    }
} 