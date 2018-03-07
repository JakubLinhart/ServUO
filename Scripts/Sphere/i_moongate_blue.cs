using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Items.UOErebor
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
    }
}