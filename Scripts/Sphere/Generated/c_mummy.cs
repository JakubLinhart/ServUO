using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Network;
using SphereSharp.ServUO;
using Server.Mobiles;

namespace Server.Sphere.UOErebor
{
    public class c_mummy : c_zombie
    {
        [Constructable]
        public c_mummy() : this("c_mummy")
        {
            OnCreated();
        }

        protected c_mummy(string defName) : base(defName)
        {
            Name = "Mummy";
            Body = 0x0003;
            VirtualArmor = 40;
            SetDamage(30, 30);
        }

        [Constructable]
        public c_mummy(Serial serial) : base(serial)
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
