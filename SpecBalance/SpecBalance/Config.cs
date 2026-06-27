using BepInEx.Configuration;

namespace SpecBalance
{
    internal static class ConfigManager
    {
        // ===== Multipliers =====

        public static ConfigEntry<float> HpMultiplier = null!;

        public static ConfigEntry<float> HandlingMultiplier = null!;

        public static ConfigEntry<float> BrakeMultiplier = null!;

        // ===== Clamp =====

        public static ConfigEntry<float> HandlingClamp = null!;

        public static ConfigEntry<float> BrakeClamp = null!;

        // ===== Spec tiers =====

        public static ConfigEntry<float> TierB = null!;

        public static ConfigEntry<float> TierA = null!;

        public static ConfigEntry<float> TierS = null!;

        public static ConfigEntry<float> TierX = null!;

        public static void Initialize(ConfigFile cfg)
        {
            HpMultiplier = cfg.Bind(
                "Spec",
                "HpMultiplier",
                1.0f,
                "HP score multiplier");

            HandlingMultiplier = cfg.Bind(
                "Spec",
                "HandlingMultiplier",
                0.1f,
                "Handling score multiplier");

            BrakeMultiplier = cfg.Bind(
                "Spec",
                "BrakeMultiplier",
                0.1f,
                "Brake score multiplier");

            HandlingClamp = cfg.Bind(
                "Spec",
                "HandlingClamp",
                100f,
                "Maximum handling bonus");

            BrakeClamp = cfg.Bind(
                "Spec",
                "BrakeClamp",
                35f,
                "Maximum brake bonus");

            TierB = cfg.Bind(
                "Tier",
                "B",
                401f,
                "Minimum score for Tier B");

            TierA = cfg.Bind(
                "Tier",
                "A",
                551f,
                "Minimum score for Tier A");

            TierS = cfg.Bind(
                "Tier",
                "S",
                701f,
                "Minimum score for Tier S");

            TierX = cfg.Bind(
                "Tier",
                "X",
                951f,
                "Minimum score for Tier X");
        }
    }
}