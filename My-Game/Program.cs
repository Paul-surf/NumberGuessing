using System;

namespace My_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Får et random tal
            Random random = new Random();
            int randomNumber = random.Next(1,20);
            
            // Ændre navnet på random tal
            int FavoriteNumber = randomNumber;

            Console.WriteLine("Hello! My name is RXY-5000");

            Console.WriteLine("Can you guess my favorite number? \nHint it's between 1 and 20");
            Console.WriteLine("I'll give you 5 attempts");
                           

            // oprettelse af verfication af input & antal forsøg
            bool gameOver = false;
            int count = 0;
            int userGuess; 
            int attempts = 5;

            while (!gameOver) {
                count++;
                attempts--;

                //Her ser jeg om deres input er et tal eller et bogstav + giver userGuess værdien af input
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userGuess)) {
                    Console.WriteLine("That's not a number between 1 and 20... Try again.");
                    continue;
                }
            
                if (userGuess != FavoriteNumber && attempts == 0) {
                    Console.WriteLine("I Really thought 5 attempts were enough...\nYou lose.. Loser!");
                    gameOver = true;
                } 
                else if (userGuess > FavoriteNumber) {
                    Console.WriteLine("That's higher... Try again !");
                } 
                else if (userGuess < FavoriteNumber) {
                    Console.WriteLine("That's Lower... Try again !");
                } 
                else {
                    gameOver = true;
                    Console.WriteLine("Yes! " + userGuess + " is my favorite number \nIt took you " + count + " attempts");
                } 
            }
            // Stopper programmet
            Console.ReadLine();
        }
    }   
}