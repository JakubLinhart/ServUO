using Server.Commands;
using SphereSharp.ServUO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Sphere
{
    public static class SphereSharpInitializer
    {
        [CallPriority(-100)]
        public static void Initialize()
        {
            SphereSharpRuntime.Current = new SphereSharpRuntime();
            CommandSystem.Register("reload", AccessLevel.Administrator, new CommandEventHandler(ReloadScripts));
            EventSink.CastSpellRequest += SphereSharpRuntime.Current.HandleCastSpellRequest;
            EventSink.SkillRequested += SphereSharpRuntime.Current.HandleSkillRequest;
            EventSink.ItemCreated += SphereSharpRuntime.Current.HandleItemCreated;
        }

        private static void ReloadScripts(CommandEventArgs e)
        {
            SphereSharpRuntime.Current = new SphereSharpRuntime();
        }
    }
}
