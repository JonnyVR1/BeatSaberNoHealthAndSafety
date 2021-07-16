using HarmonyLib;

namespace NoHealthAndSafety
{
    [HarmonyPatch(typeof(DefaultScenesTransitionsFromInit), nameof(DefaultScenesTransitionsFromInit.TransitionToNextScene))]
    internal class SkipHealthAndSafetyPatch
    {
        [HarmonyPrefix]
        internal static void Skip(ref bool goStraightToMenu)
        {
            goStraightToMenu = true;
        }
    }
}