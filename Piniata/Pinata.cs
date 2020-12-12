using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using PlayerEvent = Exiled.Events.Handlers.Player;

namespace Pinata
{
    public class Pinata : Plugin<Config>
    {
        private static readonly Lazy<Pinata> LazyInstance = new Lazy<Pinata>(() => new Pinata());
        public static Pinata Instance => LazyInstance.Value;
        public override PluginPriority Priority => PluginPriority.Medium;

        public override string Author => "Michal78900";

        public override string Name => "Pinata";

        public override Version Version => new Version(1, 0, 0);

        private Pinata() { }

        private Handler handler;

        public override void OnEnabled()
        {
            if (Pinata.Instance.Config.ItemAmount > 8)
            {
                Log.Error($"Item amount is too large! (max 8 items) You have put {Pinata.Instance.Config.ItemAmount} items in a config. That is {Pinata.Instance.Config.ItemAmount - 8} items too much.");
                    return;
            }

            base.OnEnabled();

            handler = new Handler();

            PlayerEvent.Spawning += handler.OnSpawn;

        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            PlayerEvent.Spawning -= handler.OnSpawn;

            handler = null;
        }
    }
}
