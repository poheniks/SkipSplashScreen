
using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace SkipSplashScreen
{
    [BepInPlugin("poh.bepinex.plugins.skipsplashscreen", "Skip Splash Screen", "1.0.0")]
    public class SkipSplashScreenPlugin : BasePlugin
    {
        public override void Load()
        {
            Log.LogInfo("Skipping splash screens!");
            SplashCards.showTime = float.MinValue;
        }
    }
}
