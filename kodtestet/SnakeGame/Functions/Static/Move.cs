using SnakeGame.Types.Composite;

namespace SnakeGame.Functions.Static
{
    class Move
    {
        public static void Run(GameState state)
        {
            int dx = 0, dy = 0;
            switch (state.SnakeSupplementals.Direction)
            {
                case 0:
                    dx = -1;
                    break;
                case 1:
                    dy = +1;
                    break;
                case 2:
                    dx = +1;
                    break;
                case 3:
                    dy = -1;
                    break;
            }
            var prevHead = state.SnakeSupplementals.Head;
            state.SnakeSupplementals.Head = (state.SnakeSupplementals.Head - 1 + state.SnakeBody.Data.Count) % state.SnakeBody.Data.Count;
            state.SnakeBody.Data[state.SnakeSupplementals.Head] = (state.SnakeBody.Data[prevHead].Item1 + dx, state.SnakeBody.Data[prevHead].Item2 + dy);
        }
    }
}
