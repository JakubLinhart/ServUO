using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_moongate_blue : Item
    {
        [Constructable]
        public i_moongate_blue() : base(0x0F6C)
        {
        }

        [Constructable]
        public i_moongate_blue(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

		public override void OnItemUsed(Mobile from, Item item)
        {
            SphereSharpRuntime.RunItemEvent(from, item, "i_moongate_blue", "userdclick");
        }
    }
}