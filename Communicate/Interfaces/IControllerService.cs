﻿using Data.Interfaces;
using Data.Structures.Player;

namespace Communicate.Interfaces
{
    public interface IControllerService : IComponent
    {
        void PlayerEnterWorld(Player player);
        void PlayerEndGame(Player player);

        void TrySetDefaultController(Player player);
        void SetController(Player player, IController controller);
    }
}
