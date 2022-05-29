using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class HiddenWord
    {
        private List<string> wordList = new List<string>() {
            "hello",
            "pancake",
            "chicken",
            "cow",
            "spaceship"
            };

        private string randomWord = "";

        /// Create a function that calls the class
        public HiddenWord()
        {
            
        }

        ///Create a function that gets a random word from the list
        public string getWord()
        {
            // Declare ran
            string randomWord = "";

            // Call a random number to use to pull a random word from the word list 
            //using the index
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, wordList.Count);
            randomWord = wordList[RandomIndex];
            return randomWord;
                

        }

    }
}
