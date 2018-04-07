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
    public class D_RACEclass_classes : Gump
    {
		public static void Initialize()
        {
			SphereSharpRuntime.Current.RegisterServUOType<D_RACEclass_classes>("D_RACEclass_classes");
        }

        public D_RACEclass_classes() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.Current.RunDialogTrigger("D_RACEclass_classes", this, sender, info);
        }
    }
}
