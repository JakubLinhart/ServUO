using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SphereSharp.ServUO;
using Server.Mobiles;

namespace Server.Sphere.UOErebor
{
    public class c_zombie : SphereCreature
    {
        [Constructable]
        public c_zombie() : this("c_zombie")
        {
            OnCreated();
        }

        protected c_zombie(string defName) : base(defName, AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.2)
        {
			Name = "Zombie";
			Body = 0x0003;
			VirtualArmor = 15;
			SetDamage(16, 16);
        }

        public c_zombie(Serial serial) : base(serial)
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
