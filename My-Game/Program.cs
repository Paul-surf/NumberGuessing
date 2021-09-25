using System;
using System.Diagnostics;
using System.Threading;

namespace My_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! My name is RXY-5000");
            Thread.Sleep(1000);
            Console.WriteLine("Can you guess my favorite number?");
            Thread.Sleep(1500);
            Console.WriteLine("**HINT** it's between 1 and 20");
            Thread.Sleep(1500);
            Console.WriteLine("I'll give you 5 attempts");
            Thread.Sleep(1000);

            // Laver en DO-While loop for og have en gen-af-spil mulighed
            do {
            // Får et random tal
            Random random = new Random();
            int randomNumber = random.Next(1,20);
            
            // Ændre navnet på random tal
            int FavoriteNumber = randomNumber;
            // oprettelse af verfication af input & antal forsøg
            bool gameOver = false;
            int count = 0;
            int userGuess; 
            int attempts = 5;


            Console.WriteLine("Guess: ");

            while (!gameOver) {
                count++;
                attempts--;

                //Her ser jeg om deres input er et tal eller et bogstav + giver userGuess værdien af input
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userGuess)) {
                    Console.WriteLine("That's not a number between 1 and 20... Try again.");
                    continue;
                }

                // Her tjekker vi om der er brugt 5 forsøg uden og have ramt "FavoriteNumber"
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
            Console.WriteLine("Do you want to replay?");
            } while (Console.ReadLine().ToUpper() == "YES");
            // Stopper programmet hvis "No" og Genstarter programmet hvis Ja
        }
    }   
}