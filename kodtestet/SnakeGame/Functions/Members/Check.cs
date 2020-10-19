using SnakeGame.Interfaces;
using SnakeGame.Services;
using SnakeGame.Types.Composite;
using System;

namespace SnakeGame.Functions.Members
{
    class Check
    {
        private IRandomizer _randomizer;

        public Check()
        {
            _randomizer = new Randomizer();
        }

        public void Run(GameState state)
        {
            var head = state.SnakeBody.Data[state.SnakeSupplementals.Head];
            if (head.Item1 < 0)
                state.GameOver.Data = true;
            if (head.Item1 > Console.WindowWidth)
                state.GameOver.Data = true;
            if (head.Item2 < 0)
                state.GameOver.Data = true;
            if (head.Item2 > Console.WindowHeight)
                state.GameOver.Data = true;
            if (head == state.FoodPosition.Data)
                state.FoodPosition.Data = _randomizer.GetRandomScreenPosition();
        }
    }
}
