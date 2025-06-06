using HarmonyLib;

namespace _9KCheatMode.Hooks;

[Harmony]

public class CheatsManagerPatch {


    [HarmonyPatch(typeof(MainMenuUI.MainMenuUI), nameof(MainMenuUI.MainMenuUI.OnEnable))]
    public class EnableGodlikePatch {
        public static void Postfix() {
            Systems.CheatSystem.Enable();
        }
    }
}
