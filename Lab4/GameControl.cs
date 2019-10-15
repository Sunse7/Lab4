using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GameControl
    {
        public int TotalMovesMade { get; private set; } = 0;
        private InputHandler playerMovement = new InputHandler();
        GameStateManager gameState = new GameStateManager();

        public int GenerateAndPlayGame()
        {
            gameState.GenerateMapObjects();
            Tile currentRoom;
            while (true)
            {
                gameState.PrintGamestate();
                currentRoom = gameState.GetTileObject(gameState.player.Xposition, gameState.player.Yposition);
                TotalMovesMade += currentRoom.MovementCost;

                if (VictoryController(currentRoom) == true)
                    return TotalMovesMade;

                MovementQuery(playerMovement.PlayerMoveInput());
            }
        }

        private bool VictoryController(Tile currentRoom) 
        {
                if (currentRoom != null && currentRoom.HasWon() == true)
                    return true;

                return false;
        }

        private void MovementQuery(ConsoleKey direction)
        {
            switch (direction)
            {
                case ConsoleKey.W:
                    if (UpdatePlayerState(gameState.player.Xposition, gameState.player.Yposition - 1) == true)
                        gameState.player.Yposition--;
                    break;
                case ConsoleKey.S:
                    if (UpdatePlayerState(gameState.player.Xposition, gameState.player.Yposition + 1) == true)
                        gameState.player.Yposition++;
                    break;
                case ConsoleKey.D:
                    if (UpdatePlayerState(gameState.player.Xposition + 1, gameState.player.Yposition) == true)
                        gameState.player.Xposition++;
                    break;
                case ConsoleKey.A:
                    if (UpdatePlayerState(gameState.player.Xposition - 1, gameState.player.Yposition) == true)
                        gameState.player.Xposition--;
                    break;
            }
        }

        private bool UpdatePlayerState(int x, int y)
        {
            Tile direction = gameState.GetTileObject(x, y);
            if (direction is IInteractable)
                (direction as IInteractable).PlayerInteract(gameState);

            return direction.CanPass();
        }
    }
}
