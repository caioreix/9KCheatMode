using BepInEx.Configuration;
using BepInEx.Logging;

namespace _9KCheatMode.Settings;

public class Config {
    public static void Load(ConfigFile configFile, ManualLogSource logger, string worldType) {
        // Settings setup
        ENV.Settings.Setup();
        Utils.Settings.Config.Setup(MyPluginInfo.PLUGIN_GUID, configFile);
        Utils.Settings.Config.Load(); // just load this after setup all actions.

        // Logger setup
        Utils.Logger.Config.Setup(logger, worldType);
    }
}
