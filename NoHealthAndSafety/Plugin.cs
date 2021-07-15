using IPA;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public static string PluginName => "NoHealthAndSafety";

        [Init]
        public void Init(IPALogger logger) { Logger.log = logger; }

        [OnStart]
        public void OnApplicationStart()
        {

        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }
    }
}