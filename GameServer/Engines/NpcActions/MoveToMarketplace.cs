﻿using Data.Interfaces;
using GameServer.Networks.Packets.Response;

namespace GameServer.Engines.NpcActions
{
    public class MoveToMarketplace : INpcAction
    {
        public void Execute(ISession session, int shopId, int actionId, int tabIndex)
        {
            new ResponseNpcInteraction(shopId, actionId).Send(session);
        }
    }
}
