using SnakeGame.Interfaces;
using SnakeGame.Services;
using SnakeGame.Types.Composite;
using System;
using System.Collections.Generic;

namespace SnakeGame.Functions.Static
{
    class Init
    {
        private IRandomizer _randomizer = new Randomizer();

        public void Run(GameState state)
        {
            Console.CursorVisible = false;
            state.FoodPosition.Data = _randomizer.GetRandomScreenPosition();

            state.SnakeBody.Data = new List<(int, int)>();
            for (int i = 0; i < 5; i++)
            {
                state.SnakeBody.Data.Add((10 + i, 10));
            }
        }
    }
}
