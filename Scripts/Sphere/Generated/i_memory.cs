using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class i_memory : SphereItem
    {
	    public static void Initialize()
        {
            SphereSharpRuntime.Current.RegisterServUOType<i_memory>("i_memory");
        }

        [Constructable]
        public i_memory() : base(0x2007, "i_memory")
        {
        }
		
		protected i_memory(string defName) : base(0x2007, defName)
        {
        }

        [Constructable]
        public i_memory(Serial serial) : base(serial)
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
            SphereSharpRuntime.Current.RunItemEvent(from, item, "i_memory", "userdclick");
        }
    }
}