using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;

namespace MicroVaporate
{
    internal sealed class EventHandlers
    {
        public void OnDying(DyingEventArgs ev)
        {
            if (ev.DamageHandler.Type == DamageType.MicroHid)
            {
                ev.IsAllowed = false;
                ev.Player.Vaporize();
            }
        }
    }
}
