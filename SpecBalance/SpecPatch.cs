using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace SpecBalance
{
    [HarmonyPatch(typeof(GodConstant), "GetSpecFromHP")]
    internal static class SpecPatch
    {
        private static ManualLogSource Log => Plugin.Log;

        // ВАЖНО:
        // Типы и имена параметров здесь предположительные.
        static bool Prefix(
            ref int __result,
            float hp,
            int handlingLevel,
            int brakeLevel)
        {
            float score =
                hp * Config.HpMultiplier.Value +
                Mathf.Clamp(
                    handlingLevel * Config.HandlingMultiplier.Value,
                    0f,
                    100f) +
                Mathf.Clamp(
                    brakeLevel * Config.BrakeMultiplier.Value,
                    0f,
                    35f);

            if (score < Config.TierB.Value)
                __result = 0;
            else if (score < Config.TierA.Value)
                __result = 1;
            else if (score < Config.TierS.Value)
                __result = 2;
            else if (score < Config.TierX.Value)
                __result = 3;
            else
                __result = 5;

            Log.LogInfo(
                $"Spec score={score:F1} " +
                $"HP={hp} Handling={handlingLevel} Brake={brakeLevel}");

            return false; // пропустить оригинальный метод
        }
    }
}