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
    public class D_RACEclass_info : Gump
    {
		public static void Initialize()
        {
			SphereSharpRuntime.Current.RegisterServUOType<D_RACEclass_info>("D_RACEclass_info");
        }

        public D_RACEclass_info() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.Current.RunDialogTrigger("D_RACEclass_info", this, sender, info);
        }
    }
}
