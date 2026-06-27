using BepInEx.Logging;

namespace SpecBalance
{
    public static class Log
    {
        private static ManualLogSource logger;

        public static void Info(string msg)
        {
            logger ??=
                BepInEx.Logging.Logger.CreateLogSource("SpecBalance");

            logger.LogInfo(msg);
        }

        public static void Warning(string msg)
        {
            logger ??=
                BepInEx.Logging.Logger.CreateLogSource("SpecBalance");

            logger.LogWarning(msg);
        }

        public static void Error(string msg)
        {
            logger ??=
                BepInEx.Logging.Logger.CreateLogSource("SpecBalance");

            logger.LogError(msg);
        }
    }
}