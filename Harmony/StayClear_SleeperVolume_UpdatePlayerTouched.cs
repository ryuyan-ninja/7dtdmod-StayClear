using System;
using System.Reflection;
using Harmony;
using DMT;
using UnityEngine;

[HarmonyPatch(typeof(SleeperVolume))]
[HarmonyPatch("UpdatePlayerTouched")]
class StayClear_SleeperVolume_UpdatePlayerTouched : IHarmony
{
    protected static string Product = "io.stealthbit.7dtdmods.StayClear";

    static bool Prefix(ref ulong ___respawnTime, World _world)
    {
        ___respawnTime = _world.worldTime + 120000UL;

        return true;
    }

    public virtual void Start()
    {
        Debug.Log(String.Format("Loading Harmony Patch: {0} | Classes: {1}", Product, GetType()));
        var harmony = HarmonyInstance.Create(Product);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}