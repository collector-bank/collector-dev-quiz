using SnakeGame.Functions.Members;
using SnakeGame.Functions.Static;
using SnakeGame.Interfaces;
using SnakeGame.Types.Composite;
using System;
using System.Threading;

namespace SnakeGame.Services
{
    class Game : IGame
    {
        private GameState state = new GameState();
        private Action InitHandler;
        private Action DrawHandler;
        private Action GetInputHandler;
        private Action CheckHandler;
        private Action MoveHandler;

        public Game()
        {
            var initInstance = new Init();
            InitHandler = () => initInstance.Run(state);
            DrawHandler = () => Draw.Run(state);
            GetInputHandler = () => GetInput.Run(state);
            var checkInstance = new Check();
            CheckHandler = () => checkInstance.Run(state);
            MoveHandler = () => Move.Run(state);
        }

        public void Run()
        {
            InitHandler();
            Console.WriteLine("Snake - the game! Eat as many 'X' as you can. Use 'w', 'a', 's', 'd' to change direction of the snake.");
            Console.WriteLine("Press enter to start...");
            Console.ReadLine();
            while (!state.GameOver.Data)
            {
                DrawHandler();
                GetInputHandler();
                MoveHandler();
                Thread.Sleep(250);
                CheckHandler();
            }
            Console.Clear();
            Console.WriteLine("Game over");
        }
    }
}
