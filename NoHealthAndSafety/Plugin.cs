using HarmonyLib;
using IPA;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        public static string PluginName => "NoHealthAndSafety";
        private static readonly string _harmonyID = $"com.Mystogan.{PluginName}";
        private readonly Harmony _harmony;

        [Init]
        public Plugin(IPALogger logger)
        {
            Logger.log = logger;
            _harmony = new Harmony(_harmonyID);
        }

        [OnEnable]
        public void OnEnable()
        {
            _harmony.PatchAll();
        }

        [OnDisable]
        public void OnDisable()
        {
            _harmony.UnpatchAll(_harmonyID);
        }
    }
}