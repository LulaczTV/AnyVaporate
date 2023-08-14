using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Structs;

namespace MicroVaporate
{
    public class Plugin : Plugin<Config>
    {

        public static Plugin Instance;


        public override string Name => "MicroVaporate";
        public override string Author => "pan_andrzej";
        public override Version Version => new Version(1, 0, 1);
        public override Version RequiredExiledVersion => new Version(7, 2, 0);

        private EventHandlers EventHandler { get; set; }

        public override void OnEnabled()
        {
            Instance = this;
            EventHandler = new EventHandlers();

            RegisterEvents();
            base.OnEnabled();

            Log.Debug("MicroVaporate loaded succesfully");
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
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.Dying -= EventHandler.OnDying;

        }


    }
}