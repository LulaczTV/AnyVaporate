using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace MicroVaporate
{
    public class Plugin : Plugin<Config>
    {

        public static Plugin Instance;


        public override string Name => "PA-MicroVaporate";
        public override string Author => "pan_andrzej";
        public override Version Version => new Version(1, 1, 1);
        public override Version RequiredExiledVersion => new Version(8, 8, 0);

        private EventHandlers EventHandler { get; set; }

        public override void OnEnabled()
        {
            Instance = this;
            EventHandler = new EventHandlers();

            RegisterEvents();
            base.OnEnabled();

            Log.Debug("PA-MicroVaporate loaded succesfully");
        }

        public override void OnDisabled()
        {
            Instance = null;
            EventHandler = null;

            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Dying += EventHandler.OnDying;
            Exiled.Events.Handlers.Player.Hurting += EventHandler.OnHurting;
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.Dying -= EventHandler.OnDying;
            Exiled.Events.Handlers.Player.Hurting -= EventHandler.OnHurting;
        }
    }
}