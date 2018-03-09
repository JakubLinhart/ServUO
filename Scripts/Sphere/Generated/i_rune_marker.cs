using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_rune_marker : SphereItem
    {
        [Constructable]
        public i_rune_marker() : base(0x1F14, "i_rune_marker")
        {
        }
		
		protected i_rune_marker(string defName) : base(0x1F14, defName)
        {
        }

        [Constructable]
        public i_rune_marker(Serial serial) : base(serial)
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
            SphereSharpRuntime.Current.RunItemEvent(from, item, "i_rune_marker", "userdclick");
        }
    }
}