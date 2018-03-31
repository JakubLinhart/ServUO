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
    public abstract class SphereItem : Item, ISphereItem
    {
        private IHoldTags tagHolder = new StandardTagHolder();
        private IHoldTriggers triggerHolder;
        public ItemDef Def { get; private set; }

        public int Color { get { return this.Hue; } set { this.Hue = value; } }

        protected SphereItem(Serial serial) : base(serial)
        {
            throw new NotImplementedException();
        }

        public SphereItem(int itemId, string defName) : base(itemId)
        {
            Def = SphereSharpRuntime.Current.CodeModel.GetItemDef(defName);
            triggerHolder = new StandardTriggerHolder(name => Def.Triggers[name],
                SphereSharpRuntime.Current.RunCodeBlock);
        }

        public void Tag(string key, string value)
        {
            tagHolder.Tag(key, value);
        }

        public string Tag(string key)
        {
            return tagHolder.Tag(key);
        }

        public void RemoveTag(string key)
        {
            tagHolder.RemoveTag(key);
        }

        public string Run(string triggerName, EvaluationContext context)
        {
            return triggerHolder.RunTrigger(triggerName, context);
        }
    }
}
