using SnakeGame.Types.Composite;
using System;

namespace SnakeGame.Functions.Static
{
    class GetInput
    {
        public static void Run(GameState state)
        {
            if (Console.KeyAvailable)
            {
                var ch = Console.ReadKey(true);
                switch (ch.KeyChar)
                {
                    case 'a':
                        state.SnakeSupplementals.Direction = 0;
                        break;
                    case 's':
                        state.SnakeSupplementals.Direction = 1;
                        break;
                    case 'd':
                        state.SnakeSupplementals.Direction = 2;
                        break;
                    case 'w':
                        state.SnakeSupplementals.Direction = 3;
                        break;
                }
            }
        }
    }
}
