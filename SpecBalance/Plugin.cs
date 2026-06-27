using BepInEx;
using BepInEx.Unity.IL2CPP;

using HarmonyLib;

namespace SpecBalance
{
    [BepInPlugin(
        PluginGuid,
        PluginName,
        PluginVersion)]
    public class Plugin : BasePlugin
    {
        public const string PluginGuid = "com.specbalance.mod";

        public const string PluginName = "Spec Balance";

        public const string PluginVersion = "1.0.0";

        public override void Load()
        {
            Log.Info("Loading Spec Balance...");

            ConfigManager.Initialize(Config);

            Harmony harmony = new Harmony(PluginGuid);

            harmony.PatchAll();

            Log.Info("Loaded.");
        }
    }
}