# Unity_Toggle_InspectorMode
Script that allows you to toggle Inspector Mode in UnityEditor.
> [!NOTE]
It was written in code using reflections due to internal access restrictions.

## Script
[ShortcutExtenstion.cs](ShortcutExtenstion.cs)

## How To Use
### Import Script [ShortcutExtenstion.cs](ShortcutExtenstion.cs)
- **Script:**  Import the script into your unity project
### Check the shortcut
- **Defalut Shortcut Bind:** Automatically register with Shortcut using the attribute [InitializeOnLoadMethod].
> [!NOTE]
ShortcutKeyCode is assigned "F12" by default, and if necessary, modify "menuPath" and "shortcutKey" in the script
