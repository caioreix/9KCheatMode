
namespace _9KCheatMode.Behaviors;

public class KeyBinds {
    public static void Register() {
        // Register keybinds here
        // Example: BepInEx.Configuration.ConfigEntry<BepInEx.Configuration.KeyCode> myKeybind = Config.Bind("Keybinds", "MyKey", KeyCode.F1, "Description of the keybind");

        // Log the registration
        Utils.Logger.Log.Info("Keybinds registered");
    }

    public static void Unregister() {
        // Unregister keybinds here
        // Log the unregistration
        Utils.Logger.Log.Info("Keybinds unregistered");
    }
}
