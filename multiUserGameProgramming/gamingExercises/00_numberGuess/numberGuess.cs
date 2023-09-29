// Alexander Jones, Program Template,  v0.04
using System;
/*
Generate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print game instructions including range of numbers (i.e. 0-10, 0-50, 0-100)
    MATCH == first player to score 3 points.
    ROUND == guessing a pecific number, until correct or no more attempts
    Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
    If guess is corrrect {
        Tell them they have guessed correctly.
        Award the player a point.
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low.
        Check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
        
    
    }
    */
namespaceess numberGuess
{
    class numberGuess
    {
         static void Main(string[] args)
         {

       }
            int seccretNumber = -1;
            int numGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; // Number of Guesses TAKEN.
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console,WriteLine("Welcome to the Number Guess Game!/nYou will select a difficulty next./n")
            Console.WrieLine("Easy Mode: Range is 0 - 10 with 4 guesses. /nNormal Mode: R")

            // DIFFICULTY SELECTION
            Console.WriteLine("Please type Easy, Normal, or Hard and press Enter.")
            // Console.Readline() will save to STRING by default.
            Console.WriteLine("You have selected " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;

            } else if (NORMAL MODE) {
                // Code to run.
            } else if (HARD MODE) {
                // Code to run.
            } else {
                // Code to run if no difficulty is selected.

    }
    Console.WriteLine("Minimum: " + rangeMin);
    Console.WriteLine("Maximum: " + rangeMax);
    Console.WriteLine("Nun. Guesses: " + numGuesses);

    // START THE MATCH!
    while (playerScore !=3 && cpuScore) {
        // Any code you want to run BEFORE each round goes
        // GENERATE SECRET NUMBER

        // START EACH ROUND
        for (int i = 0; i < numGuesses ; i++) {
            // Code to guess number goes here.
            // GENERATE SECRET NUMBER
            Random rndNum = new Random();
            secretNumber = rndNum.Next(0,100);
            Console.WriteLine("Player Score: " + playerScore + "\n");
            Console.WriteLine("CPU Score: " + cpuScore + "\n");
            // START EACH ROUND
            for (int i = 0; i < numGuesses ; i++) {
                // Code to guess number goes here.
                Console.WriteLine("You have used " + numAttempts + "This round");
                Console.WriteLine("You must guess between " + rangeMin + "and " + rangeMax + "./n");
                playerGuess = System.Convert.ToInt32(Console.ReadLine());
            }   if (playerGuess == secretNumber)
                    // Print a success message!
                    playerScore++;
                    break;
                } else {
                    if (playerGuess > secretNumber) {
                        Console.WriteLine("Your guess is too high!\n")
                } else {
                    Console.WriteLine("Your guess is too low!\n);
                }
            }
            numAttempts++;
    }
    if (playerGuess != secretNumber) {
        cpuScore++
    }
        }
}
    class numberGuess
    {
        static void Main(string[] args)
    }
 