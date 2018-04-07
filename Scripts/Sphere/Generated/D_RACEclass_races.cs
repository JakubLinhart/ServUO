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
    public class D_RACEclass_races : Gump
    {
		public static void Initialize()
        {
			SphereSharpRuntime.Current.RegisterServUOType<D_RACEclass_races>("D_RACEclass_races");
        }

        public D_RACEclass_races() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.Current.RunDialogTrigger("D_RACEclass_races", this, sender, info);
        }
    }
}
