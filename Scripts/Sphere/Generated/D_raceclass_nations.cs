using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Gumps;
using Server.Network;
using Server.Sphere;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class D_raceclass_nations : Gump
    {
		public static void Initialize()
        {
			SphereSharpRuntime.Current.RegisterServUOType<D_raceclass_nations>("D_raceclass_nations");
        }

        public D_raceclass_nations() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.Current.RunDialogTrigger("D_raceclass_nations", this, sender, info);
        }
    }
}
