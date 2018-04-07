using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Network;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_rune_base : i_rune_marker
    {
	    public new static void Initialize()
        {
            SphereSharpRuntime.Current.RegisterServUOType<i_rune_base>("i_rune_base");
        }

        [Constructable]
        public i_rune_base() : base("i_rune_base")
        {
        }

		protected i_rune_base(string defName) : base(defName)
        {
        }

        [Constructable]
        public i_rune_base(Serial serial) : base(serial)
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
            SphereSharpRuntime.Current.RunItemEvent(from, item, "i_rune_base", "userdclick");
        }
    }
}