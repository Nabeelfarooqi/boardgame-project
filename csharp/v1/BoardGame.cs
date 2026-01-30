using System;
using System.Diagnostics;

namespace BoardGame
{
    static class RollDice
    {
        public static void Roll()
        {
            Random rand = new Random();
            int diceValue1 = rand.Next(1, 7);
            int diceValue2 = rand.Next(1, 7);
            Console.WriteLine("You rolled a " + diceValue1 + " and " + diceValue2);

            if(diceValue1 == 6 && diceValue2 == 6)
            {
                Console.WriteLine("Congratulations! You rolled double sixes!");
                int bonusRoll1 = rand.Next(1, 7);
                int bonusRoll2 = rand.Next(1, 7);
                Console.WriteLine("You rolled a " + bonusRoll1 + " and " + bonusRoll2 + " on your bonus roll.");
            }
        }
    } 

    static class PlayerTurn
    {
        public static void PlayerName(string playerName = "")
        {
            int totalPlayers = 4;
            string [] playernames = new string[totalPlayers];
            int actualPlayer = 0;


            for( int i = 0; i<totalPlayers; i++)
            {
               Console.WriteLine($"Enter your name Player{i+1} (or press 'q' to stop): ");
               string input = Console.ReadLine();
               if(input.ToLower() == "q")
               {
                   break;
               }
               playernames[i] = input;
               actualPlayer++;
               Console.WriteLine("Welcome to the game "+playernames[i]+"!");

            }
            Console.WriteLine($"Total players joined: {actualPlayer}");
        }
        public static void Start()
    {
        // Placeholder for future implementation of player turns
    }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Board Game!");
            PlayerTurn.PlayerName();
            RollDice.Roll();  
            
        
        }
    }
}
