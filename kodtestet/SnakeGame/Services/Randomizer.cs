using SnakeGame.Interfaces;
using System;

namespace SnakeGame.Services
{
    class Randomizer : IRandomizer
    {
        private Random _random = new Random();

        public (int, int) GetRandomScreenPosition() =>
            (_random.Next(0, Console.WindowWidth), _random.Next(0, Console.WindowHeight));
    }
}
