using System;
using unit02_hilo;

namespace unit02_hilo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Call the director class
            Director director = new Director();

            // Call the function in the Director class StartGame
            director.StartGame();

        }
    }
}
