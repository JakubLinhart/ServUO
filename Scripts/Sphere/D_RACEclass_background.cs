using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Gumps;
using Server.Network;
using Server.Sphere;
using SphereSharp.ServUO;

namespace Server.Items.UOErebor
{
    public class D_RACEclass_background : Gump
    {
        public static void Initialize()
        {
            SphereSharpRuntime.RegisterGump<D_RACEclass_background>("D_RACEclass_background");
        }

        public D_RACEclass_background() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.RunDialogTrigger("D_RACEclass_background", sender, info);
        }
    }
}
