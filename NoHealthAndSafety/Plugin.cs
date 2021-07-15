using HarmonyLib;
using IPA;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    [Plugin(RuntimeOptions.SingleStartInit)]
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

        [OnStart]
        public void OnApplicationStart()
        {
            _harmony.PatchAll();
        }

        [OnExit]
        public void OnApplicationQuit()
        {
            _harmony.UnpatchAll(_harmonyID);
        }
    }
}