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

        }

        public void Search(char letter) {

        }

        //returns a string representation of the person
        //if there are no body parts then nothing will show
        //e.g. if you have two wrong answers then "head torso " will be output
        public StringBuilder ShowBody() {

            StringBuilder body = new StringBuilder();
            string[] bodyParts = { "head ", "torso ", "left arm ", "right arm ", "left leg ", "right leg " };

            if (bodyCounter != 0) {

                body.Append(bodyParts[bodyCounter - 1]);
            }

            return body;

        }

    }

}
