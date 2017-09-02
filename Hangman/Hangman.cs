using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {

    class Hangman {

        private int bodyCounter; //counts how many bosy parts there currently are
        private char[] letters; //contains each individual letter of the sentence entered by the user
        private char[] guesses; //the string representation of the correct guesses
        private List<char> wrong; //the wrong guesses

        public Hangman(string sentence) {

            bodyCounter = 0;
            letters = sentence.ToCharArray();
            guesses = new char[letters.Length];
            wrong = new List<char>();

            //creates the blank guess message that the player would check his guesses with
            for (int i = 0; i < letters.Length; i++) {

                if (letters[i].Equals(' ')) {

                    guesses[i] = ' ';

                }
                else {

                    guesses[i] = '_';

                }

            }

        }

        //searches the sentence for the letter that the user is looking for
        //if it finds it then it adds it to the sentence that's being guessed
        //if it doesn't find it th method adds it to the list of wrong letters
        public void Search(char letter) {

            for (int i = 0; i < letters.Length; i++) {

                if (letters[i].Equals(letter)) {

                    guesses[i] = letter;

                }
                else {

                    wrong.Add(letter);

                }

            }

        }

        //returns a string representation of the person
        //if there are no body parts then nothing will show
        //e.g. if you have two wrong answers then "head torso " will be output
        public StringBuilder ShowBody() {

            StringBuilder body = new StringBuilder();
            string[] bodyParts = { "head \n", "torso \n", "left arm \n", "right arm \n", "left leg \n", "right leg \n" };

            if (bodyCounter != 0) {

                body.Append(bodyParts[bodyCounter - 1]);
            }

            return body;

        }

    }

}
