using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Network;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_hiding_timer : i_memory
    {
	    public new static void Initialize()
        {
            SphereSharpRuntime.Current.RegisterServUOType<i_hiding_timer>("i_hiding_timer");
        }

        [Constructable]
        public i_hiding_timer() : base("i_hiding_timer")
        {
        }

		protected i_hiding_timer(string defName) : base(defName)
        {
        }

        [Constructable]
        public i_hiding_timer(Serial serial) : base(serial)
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
            SphereSharpRuntime.Current.RunItemEvent(from, item, "i_hiding_timer", "userdclick");
        }
    }
}