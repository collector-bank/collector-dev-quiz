using SnakeGame.Functions.Members;
using SnakeGame.Functions.Static;
using SnakeGame.Types.Composite;
using System;
using System.Threading;

namespace SnakeGame.Classes
{
    class Game
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
            while (!state.GameOver.Data)
            {
                DrawHandler();
                GetInputHandler();
                MoveHandler();
                Thread.Sleep(250);
                CheckHandler();
            }
            Console.WriteLine("Game over");
        }
    }
}
