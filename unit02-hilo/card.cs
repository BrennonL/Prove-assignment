using System;

namespace unit02_hilo
{
    class Card
    {

        // Give the card class an varaible called Value which 
        //stores an integer
        public int Value = 0;

        public Card()
        {

        }



        ///<summery>
        /// This meathod will take the card value and get a random number between
        ///1-12
        ///</summery>
        public void GetNewCard()
        {
            Random RandomGenereator = new Random();
            Value = RandomGenereator.Next(1,13);
        }
    }
}