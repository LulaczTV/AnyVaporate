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
            foreach(var damageType in Plugin.Instance.Config.damageTypes)
            {
                if (ev.DamageHandler.Type == damageType && ev.DamageHandler.Type != DamageType.ParticleDisruptor)
                {
                    ev.IsAllowed = false;
                    ev.Player.Vaporize();
                }
            }
        }
    }
}
