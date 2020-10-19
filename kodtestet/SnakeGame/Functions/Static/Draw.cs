using SnakeGame.Types.Composite;
using System;

namespace SnakeGame.Functions.Static
{
    class Draw
    {
        public static void Run(GameState state)
        {
            Console.Clear();
            for (int i = 0; i < state.SnakeBody.Data.Count; i++)
            {
                Console.SetCursorPosition(state.SnakeBody.Data[i].Item1, state.SnakeBody.Data[i].Item2);
                Console.Write('*');
            }

            Console.SetCursorPosition(state.FoodPosition.Data.Item1, state.FoodPosition.Data.Item2);
            Console.Write('X');
        }
    }
}
