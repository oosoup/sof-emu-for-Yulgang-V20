﻿using Communicate.Logics;

namespace GameServer.Networks.Packets.Request
{
    public class RequestAuth : ARecvPacket
    {
        protected string Username;
        protected string IpAddress;
        protected string MacAddress;

        public override void ExecuteRead()
        {
            Username = ReadS(22).Replace("\0", "");
            ReadB(42);
            ReadD(); // Unk
            IpAddress = ReadS(16).Replace("\0", "");
            MacAddress = ReadS(16).Replace("\0", "");
        }

        public override void Process()
        {
            AccountLogic
                .TryAuthorize(session, Username, IpAddress, MacAddress);
        }
    }
}
