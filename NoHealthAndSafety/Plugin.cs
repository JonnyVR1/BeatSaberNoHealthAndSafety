using HarmonyLib;
using IPA;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        public static string PluginName => "NoHealthAndSafety";
        private static readonly string HarmonyID = $"com.Mystogan.{PluginName}";
        private readonly Harmony _harmony;

        [Init]
        public Plugin(IPALogger logger)
        {
            Logger.Log = logger;
            _harmony = new Harmony(HarmonyID);
        }

        [OnEnable]
        public void OnEnable()
        {
            _harmony.PatchAll();
        }

        [OnDisable]
        public void OnDisable()
        {
            _harmony.UnpatchAll(HarmonyID);
        }
    }
}