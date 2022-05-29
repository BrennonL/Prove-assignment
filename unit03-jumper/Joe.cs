using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Joe
    {

        // This list has all the strings for joe's body
        List<string> bodyJoe = new List<string>()
        {
            " ___",
            @"/___\",
            @"\   /",
            @" \ /",
            "  o",
            @" /|\",
            @" / \",
            "",
            "^^^^^^^^^"

        };

        // This list is so that in the end the game displays 
        //blank lines for the number of letters in the word
        public List<string> BlankWord = new List<string>();

        public int lifeJoe = 0;


        



        public Joe()
        {

        }


        /// This function displays joe's body by looping through the joe list
        public void DisplayJoe()
        {
            foreach(string item in bodyJoe)
            {
                Console.WriteLine(item);
            }

        }

        // This counts the number of letters in the Unknown word and displays that 
        public void CreateBlankWord(string UnknownWord)
        {
            for(int i = 0; i<UnknownWord.Length; i++)
            {
                BlankWord.Add("_");
            }



        }

        public void DisplayBlankWord()
        {

            foreach(string blank in BlankWord)
            {
                Console.Write($"{blank} ");
            }
        }


        public void addGuessToBlankWord(string guess, string UnknownWord)
        {
            // Turn the guess sting into a character so that later it can be 
            //checked to see if it is in a list
            char guessChar = char.Parse(guess);

            // Created a variable to keep track of the index of where to place 
            //the letter in the blank word 
            int index = 0;

            // Compairs the guess to each letter in the unknow word and then 
            //it adds it to the BlankWord list if it is in the word
            foreach(char letter in UnknownWord)
            {
                
                if(letter == guessChar)
                {
                    BlankWord[index] = guess;
                }

                index ++;
            }

        }

        // If the letter is guessed wrong this meathod makes joe loose a life
        //but if he has lost 5 lives it makes it so in the end he dies
        public void makeJoeLooseLife()
        {
            if (lifeJoe == 3)
            {
                bodyJoe.RemoveAt(0);
                bodyJoe[0] = "  x";


                lifeJoe ++;




            }

            else
            {
                bodyJoe.RemoveAt(0);
                lifeJoe ++;

            }

        }

        
        public int FindWinnerStatus(string UnknownWord)
        {
            int numberOfLetters = 0;

            foreach(string letter in BlankWord)
            {
                char letterchar = char.Parse(letter);
                if (UnknownWord.Contains(letterchar))
                {
                    numberOfLetters ++;
                    
                }
            }
            if(numberOfLetters == UnknownWord.Length)
            {
                return 1;

            }

            else
            {
                return 0;
            }

        }


    }
}