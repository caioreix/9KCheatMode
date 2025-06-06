using UnityEngine;
using Utils.Logger;
using Utils.Settings;

namespace _9KCheatMode.Settings;

public static class ENV {
    // Mission_General
    private readonly static string general = "🕹️ General";
    private readonly static string settings = "⚙️ Settings";
    public static readonly ConfigElement<bool> EnableCastleAutoShoot = Utils.Settings.Config.Bind(
        general,
        nameof(EnableCastleAutoShoot),
        true,
        "Enable Castle Auto Shoot"
    );
    public static readonly ConfigElement<bool> EnableDisableUI = Utils.Settings.Config.Bind(
        general,
        nameof(EnableDisableUI),
        true,
        "Enable Disable UI"
    );
    public static readonly ConfigElement<bool> EnableGodLike = Utils.Settings.Config.Bind(
        general,
        nameof(EnableGodLike),
        true,
        "Enable God Like"
    );
    public static readonly ConfigElement<bool> EnableInfinityLifes = Utils.Settings.Config.Bind(
        general,
        nameof(EnableInfinityLifes),
        true,
        "Enable Infinity Lifes"
    );
    public static readonly ConfigElement<bool> EnableOIIAIOIIIAI = Utils.Settings.Config.Bind(
        general,
        nameof(EnableOIIAIOIIIAI),
        true,
        "Enable OIIAIOIIIAI"
    );
    public static readonly ConfigElement<bool> EnablePerks = Utils.Settings.Config.Bind(
        general,
        nameof(EnablePerks),
        true,
        "Enable Perks"
    );

    public static readonly ConfigElement<KeyCode> ReloadSettings = Utils.Settings.Config.Bind(
        settings,
        nameof(ReloadSettings),
        KeyCode.F5,
        "Reload Settings KeyBind"
    );

    public static class Settings {
        public static void Setup() {
            Utils.Settings.Config.AddConfigActions(Load);
        }

        public static void Reload() {
            Utils.Settings.Config.Reload();
            Log.Info("Settings reloaded!");
        }

        // Load the plugin config variables.
        private static void Load() {
            Utils.Settings.Config.Save();
        }
    }
}
