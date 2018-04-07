using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Network;
using SphereSharp.ServUO;

namespace Server.Sphere.UOErebor
{
    public class I_stone_raceclass : i_grave_stone_4
    {
	    public new static void Initialize()
        {
            SphereSharpRuntime.Current.RegisterServUOType<I_stone_raceclass>("I_stone_raceclass");
        }

        [Constructable]
        public I_stone_raceclass() : base("I_stone_raceclass")
        {
        }

		protected I_stone_raceclass(string defName) : base(defName)
        {
        }

        [Constructable]
        public I_stone_raceclass(Serial serial) : base(serial)
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
            SphereSharpRuntime.Current.RunItemEvent(from, item, "I_stone_raceclass", "userdclick");
        }
    }
}