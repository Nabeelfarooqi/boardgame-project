using System;

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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Board Game!");
            RollDice.Roll();  
        }
    }
}
