using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_grave_stone_4 : Item
    {
        [Constructable]
        public i_grave_stone_4() : base(0x0EDB)
        {
        }

        [Constructable]
        public i_grave_stone_4(Serial serial) : base(serial)
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
            SphereSharpRuntime.RunItemEvent(from, item, "i_grave_stone_4", "userdclick");
        }
    }
}