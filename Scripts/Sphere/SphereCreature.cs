using Server.Mobiles;
using SphereSharp.Interpreter;
using SphereSharp.Model;
using SphereSharp.Runtime;
using SphereSharp.ServUO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Sphere
{
    public abstract class SphereCreature : BaseCreature, ISphereCreature
    {
        private readonly StandardTagHolder tagHolder = new StandardTagHolder();
        private readonly StandardTriggerHolder triggerHolder;

        public CharDef Def { get; private set; }
        public int MaxHits { get; set; }
        public int MaxStam { get; set; }
        public int MaxMana { get; set; }
        public int Npc { get; set; }

        public override int HitsMax { get { return MaxHits; } }
        public override int StamMax { get { return MaxStam; } }
        public override int ManaMax { get { return MaxMana; } }

        public int Parrying { get { return this.Skills[SkillName.Parry].Fixed; } set { this.Skills[SkillName.Parry].Base = value; } }
        public int Tactics { get { return this.Skills[SkillName.Tactics].Fixed; } set { this.Skills[SkillName.Tactics].Base = value; } }
        public int Wrestling { get { return this.Skills[SkillName.Wrestling].Fixed; } set { this.Skills[SkillName.Wrestling].Base = value; } }
        public int SpiritSpeak { get { return this.Skills[SkillName.SpiritSpeak].Fixed; } set { this.Skills[SkillName.SpiritSpeak].Base = value; } }

        public int Color { get { return Hue; } set { Hue = value; } }

        public SphereCreature(string defName, AIType ai, FightMode mode, int iRangePerception, int iRangeFight, double dActiveSpeed, double dPassiveSpeed)
            : base(ai, mode, iRangePerception, iRangeFight, dActiveSpeed, dPassiveSpeed)
        {
            Def = SphereSharpRuntime.Current.GetCharDef(defName);
            triggerHolder = new StandardTriggerHolder(name => Def.Triggers[name], SphereSharpRuntime.Current.RunCodeBlock);
        }

        protected void OnCreated()
        {
            var context = new EvaluationContext();
            context.Default = this;
            context.Src = this;
            RunTrigger("create", context);
        }

        public SphereCreature(Serial serial) : base(serial)
        {
        }

        public void RemoveTag(string key)
        {
            tagHolder.RemoveTag(key);
        }

        public void Tag(string key, string value)
        {
            tagHolder.Tag(key, value);
        }

        public string Tag(string key)
        {
            return tagHolder.Tag(key);
        }

        public void SubscribeEvents(EventsDef eventsDef)
        {
            triggerHolder.SubscribeEvents(eventsDef);
        }

        public void UnsubscribeEvents(EventsDef eventsDef)
        {
            triggerHolder.UnsubscribeEvents(eventsDef);
        }

        public string RunTrigger(string triggerName, EvaluationContext context)
        {
            return triggerHolder.RunTrigger(triggerName, context);
        }
    }
}
