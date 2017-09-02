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

        }
    }
}
