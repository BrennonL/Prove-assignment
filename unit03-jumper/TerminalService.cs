using System;


namespace unit03_jumper
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class TerminalService
    {

        private Joe joe = new Joe();
        

        

        public TerminalService()
        {

        }

        public void DisplayScreen()
        {
            joe.DisplayJoe();


        }

        public string GetGuess()
        {
            Console.WriteLine("");
            Console.WriteLine("Guess a letter [a-z]: ");
            string guess = Console.ReadLine();
            return guess;
        }


    }
}