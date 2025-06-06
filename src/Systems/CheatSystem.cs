using _9KCheatMode.Settings;
using CheatSystem;
using Utils.Logger;

namespace _9KCheatMode.Systems;

public class CheatSystem {
    public static void Enable() {
        try {
            CheatsManager.EnableGodlike(ENV.EnableGodLike.Value);

            EnabledCheats enabledCheats = new() {
                GodLike = ENV.EnableGodLike.Value,
                InfinityLifes = ENV.EnableInfinityLifes.Value,
                OIIAIOIIIAI = ENV.EnableOIIAIOIIIAI.Value,
                PerksEnabled = ENV.EnablePerks.Value,
                CastleAutoshoot = ENV.EnableCastleAutoShoot.Value,
                DisableUI = ENV.EnableDisableUI.Value
            };

            CheatsManager.Apply(enabledCheats);

            Log.Info("Cheats enabled");
            return;
        } catch { }
    }

    public static void Disable() {
        CheatsManager.EnableGodlike(false);

        CheatsManager.Apply(EnabledCheats.Default);

        Log.Info("Cheats disabled");
        return;
    }
}
