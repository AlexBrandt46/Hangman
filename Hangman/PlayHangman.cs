using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    class PlayHangman {
        static void Main(string[] args) {

            Hangman game; 
            string message; //message entered by the user that someone else will play the game with

            //ask user for the message to play the game with and instantiate hangman game
            Console.WriteLine("Please enter the message you'd like to play the game with.");
            message = Console.ReadLine();
            game = new Hangman(message);

            //outputs the prompt for the user based on the message
            game.OutputGuess();

            while (!(game.BodyCounter == 6)) {

                char guess; //the current guess

                Console.Write("Please enter the first letter that you'd like to guess: ");
                guess = Convert.ToChar(Console.ReadLine());

                game.Search(guess);
                game.OutputGuess();

            }

        }
    }
}
