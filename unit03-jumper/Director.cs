using System;

namespace unit03_jumper
{
    public class Director
    {

        // Called the classes HiddenWord, Joe, and TerminalSerice
        private HiddenWord hiddenWord = new HiddenWord();
        private Joe joe = new Joe();
        private TerminalService theTerminal = new TerminalService();

        string guess = "";

        private int winner = 0;

        private int endgame = 0;




        public Director()
        {
            
        }

        public void RunCode()
        {
            Console.WriteLine("Hello World");

            // Referencing the Joe class to call the DisplayJoe meathod which will display Joe
            string UnknownWord = hiddenWord.getWord();

            theTerminal.DisplayScreen();

            joe.CreateBlankWord(UnknownWord);
            do
            {

                // Call GetInputs function
                guess = GetInputs(UnknownWord);
                



                // Call DoUpdates function
                DoUpdates(guess, UnknownWord);



                // Call DoOutput function
                DoOutputs();

                if(joe.lifeJoe ==4)
                {
                    Console.WriteLine("You lost");
                    endgame = 1;
                }

                else if(winner == 1)
                {
                    Console.WriteLine("You won!");
                    endgame = 1;
                }



            }while(endgame == 0);

            joe.DisplayJoe();

            Console.WriteLine(UnknownWord.Length);



        }

        // GetInputs function
        private string GetInputs(string UnknownWord)
        {

            // This function grabs the Unknown variable and count the letters to make
            //a list of dashes

            joe.DisplayBlankWord();

            guess = theTerminal.GetGuess();

            return guess;




        }


        private void DoUpdates(string guess, string UnknownWord)
        {
            if(UnknownWord.Contains(guess))
            {
                // I want to have the BlankWord list here in this function somehow
                // could also have a function in Joe that just adds the letter to the blank list

                joe.addGuessToBlankWord(guess, UnknownWord);

            }

            else
            {
                //use a joe function to make joe loose a part of his parachuit 
                joe.makeJoeLooseLife();

            }   

            winner = joe.FindWinnerStatus(UnknownWord);
        }


  

        // DoOutputs function

        private void DoOutputs()
        {
            joe.DisplayJoe();

        }

    }
}
