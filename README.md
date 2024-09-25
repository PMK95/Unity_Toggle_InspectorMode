# Unity_Toggle_Inspector Debug Mode
A script that allows you to toggle between Normal and Debug modes in Unity's Inspector using a custom shortcut.
> [!NOTE]
This script uses reflection to access internal methods in Unity due to the restricted access to Inspector Mode functionalities.

## Script
[ShortcutExtension.cs](ShortcutExtension.cs)

## How To Use
### Import Script
- **Script:**  Import the [ShortcutExtension.cs](ShortcutExtension.cs) script into your Unity project.
### Check the shortcut
- **Default Shortcut Binding:** The shortcut is automatically registered when Unity loads, using the [InitializeOnLoadMethod] attribute.
> [!NOTE]
The default shortcut key is set to "F12." If you'd like to change it, you can modify the "menuPath" and "shortcutKey" variables in the script.
