using SnakeGame.Types.Atomic;
using SnakeGame.Types.Data;

namespace SnakeGame.Types.Composite
{
    class GameState
    {
        public SnakeBody SnakeBody { get; set; } = new SnakeBody();
        public SnakeSupplementals SnakeSupplementals { get; set; } = new SnakeSupplementals();
        public FoodPosition FoodPosition { get; set; } = new FoodPosition();
        public GameOver GameOver { get; set; } = new GameOver();
    }
}