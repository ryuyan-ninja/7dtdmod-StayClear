using HarmonyLib;

namespace StayClear
{
    [HarmonyPatch(typeof(SleeperVolume), "UpdatePlayerTouched")]
    class SleeperVolume_UpdatePlayerTouched
    {
        static bool Prefix(ref ulong ___respawnTime, World _world)
        {
            ___respawnTime = _world.worldTime + 120000UL;

            return true;
        }
    }
}