using System.Reflection;
using HarmonyLib;

namespace StayClear
{
    public class StayClear : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            var harmony = new Harmony("io.stealthbit.7dtdmods.StayClear");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
