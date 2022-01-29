using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;
using Server = Exiled.Events.Handlers.Server;

namespace InappropriateNameBan
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "quazEx";

        public override string Name => "InappropriateNameBan";

        public override string Prefix => "InappropriateNameBan";

        public override Version Version => new Version(1, 5, 0);

        public override Version RequiredExiledVersion => new Version(4, 2, 2);

        internal EventHandlers EventHandlers { get; set; }

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();
            Player.Verified += EventHandlers.OnPlayerJoining;
            Singleton = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Verified -= EventHandlers.OnPlayerJoining;
            Singleton = null;
            base.OnDisabled();
        }

        public static Plugin Singleton;

    }
}
