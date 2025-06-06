using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using Utils.Injection;

namespace _9KCheatMode;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]

public class Plugin : BasePlugin {
    public readonly static Harmony Harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
    private static Behaviors.KeyBinds keyBindsBehaviour;
    public override void Load() {
        Settings.Config.Load(Config, Log, "Client");

        IL2CPP.Unregister<Behaviors.KeyBinds>();
        keyBindsBehaviour = AddComponent<Behaviors.KeyBinds>();

        Utils.Logger.Log.Trace("Patching harmony");
        Harmony.PatchAll();

        Utils.Logger.Log.Info($"Plugin {MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} loaded!");
    }

    public override bool Unload() {
        Systems.CheatSystem.Disable();

        Utils.Logger.Log.Trace("Unpatching harmony");
        Harmony.UnpatchSelf();

        GameObject.Destroy(keyBindsBehaviour);
        IL2CPP.Unregister<Behaviors.KeyBinds>();

        Utils.Logger.Log.Info($"Plugin {MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} unloaded!");

        return true;
    }
}
