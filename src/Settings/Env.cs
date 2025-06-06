using Utils.Settings;

namespace _9KCheatMode.Settings;

public static class ENV {
    // Mission_General
    private readonly static string settings = "0.⚙️ Settings";
    public static ConfigElement<bool> EnableCastleAutoShoot;
    public static ConfigElement<bool> EnableDisableUI;
    public static ConfigElement<bool> EnableGodLike;
    public static ConfigElement<bool> EnableInfinityLifes;
    public static ConfigElement<bool> EnableOIIAIOIIIAI;
    public static ConfigElement<bool> EnablePerks;

    public static class Settings {
        public static void Setup() {
            Utils.Settings.Config.AddConfigActions(load);
        }

        // Load the plugin config variables.
        private static void load() {
            EnableCastleAutoShoot = Utils.Settings.Config.Bind(
                settings,
                nameof(EnableCastleAutoShoot),
                true,
                "Enable Castle Auto Shoot"
            );

            EnableDisableUI = Utils.Settings.Config.Bind(
                settings,
                nameof(EnableDisableUI),
                true,
                "Enable Disable UI"
            );

            EnableGodLike = Utils.Settings.Config.Bind(
                settings,
                nameof(EnableGodLike),
                true,
                "Enable God Like"
            );

            EnableInfinityLifes = Utils.Settings.Config.Bind(
                settings,
                nameof(EnableInfinityLifes),
                true,
                "Enable Infinity Lifes"
            );

            EnableOIIAIOIIIAI = Utils.Settings.Config.Bind(
                settings,
                nameof(EnableOIIAIOIIIAI),
                true,
                "Enable OIIAIOIIIAI"
            );

            EnablePerks = Utils.Settings.Config.Bind(
                settings,
                nameof(EnablePerks),
                true,
                "Enable Perks"
            );

            Utils.Settings.Config.Save();
        }
    }
}
