using System;

namespace unit02_hilo
{
    class Director
    {




        public void StartGame()
        {

            // The variables Score, NewCard, and PlayAgain have been declaired 
            int Score = 300;
            Card NewCard = new Card();
            string PlayAgain = "y";
            string Answer = "";


            // Call the the GetNewCard function from the card class
            NewCard.GetNewCard();

            do
            {
                int PreviousCard = NewCard.Value;

                // Print the card value
                Console.WriteLine($"The card is {NewCard.Value}");

                // Have the user guess higher or lower
                Console.Write("Higher of lower? [h/l] ");
                Answer = Console.ReadLine();
                
                // Call the GetNewCard Meathod from the Card class
                NewCard.GetNewCard();

                // Print the new card drawn
                Console.WriteLine($"The next card is: {NewCard.Value}");

                // Use the UpdateScore function to update the Score variable
                Score = UpdateScore(PreviousCard, NewCard, Answer, Score);

                // Print the users Score
                Console.WriteLine($"Your score is: {Score}");

                // If the user reaches a score below 0 then they loose the game
                //and the score resets so that they can play again if they 
                //want to
                if(Score >= 0)
                {
                    Score = 300;
                    Console.WriteLine("You lost");
                }

                // Ask the user if they want to play again
                Console.Write("Play again? [y/n] ");
                PlayAgain = Console.ReadLine();



                
                

            // As long as the user wants to keep playing the game continus
            }while(PlayAgain == "y");

            

        }
        

        ///<summery>
        /// The function Update Score takes the parameters of PreviousCard, NewCard
        ///Anser, and Score. If the user guesses correctly weahter the next card
        ///is higher or lower they get 100 points. If they guess incorectly they loose 75 
        ///points
        ///</summery>
        public int UpdateScore(int PreviousCard, Card NewCard, string Answer, int Score)
        {
            // if the previouse card is higher than the current card and the 
            //user guessed lower give the user 100 points
            if(PreviousCard > NewCard.Value && Answer == "l")
            {
                Score = Score + 100;
                return Score;
            }

            // if the previouse card is lower than the current card and the 
            //user guessed higher give the user 100 points

            else if(PreviousCard < NewCard.Value && Answer == "h")
            {
                Score = Score + 100;

                return Score;
            }

            // If the user didn't guess correct at all then the user
            //looses 75 points
            else
            {
                Score = Score - 75;
                return Score;
            }
            
        }




            

    }
}