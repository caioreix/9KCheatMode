
using System;
using _9KCheatMode.Settings;
using UnityEngine;

namespace _9KCheatMode.Behaviors;

public class KeyBinds(IntPtr handle) : MonoBehaviour(handle) {
    public void Update() {
        if (Input.GetKeyDown(ENV.ReloadSettings.Value)) {
            Systems.CheatSystem.Disable();
            ENV.Settings.Reload();
            Systems.CheatSystem.Enable();
        }
    }
}
