using System.Reflection;

namespace Harmony
{
    public class StayClear : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            var harmony = new HarmonyLib.Harmony("io.stealthbit.7dtdmods.StayClear");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
