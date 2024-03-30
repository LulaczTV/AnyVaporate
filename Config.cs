using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Exiled.API.Structs;

namespace MicroVaporate
{
    public sealed class Config : IConfig
    {

        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Which DamageTypes should vaporize player on dying?")]
        public List<DamageType> damageTypes = new List<DamageType>()
        {
            DamageType.MicroHid,
        };

    }
}
