using Server.Gumps;
using Server.Network;
using Server.Sphere;
using SphereSharp.ServUO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Items.UOErebor
{
    public class D_RACEclass_classes : Gump
    {
        public static void Initialize()
        {
            SphereSharpRuntime.RegisterGump<D_RACEclass_classes>("D_RACEclass_classes");
        }

        public D_RACEclass_classes() : base(0, 0)
        {
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            SphereSharpRuntime.RunDialogTrigger("D_RACEclass_classes", sender, info);
        }
    }
}
