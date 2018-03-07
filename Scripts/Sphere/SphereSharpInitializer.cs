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
        public static void Initialize()
        {
            Console.WriteLine("Initializing SphereSharp runtime");

            SphereSharpRuntime.Initialize();
        }
    }
}
