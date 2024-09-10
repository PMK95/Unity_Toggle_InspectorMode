#if UNITY_EDITOR
using System.Linq;
using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;
public class ShortcutExtenstion : MonoBehaviour
{
    private const string menuPath = "Custom/ToggleInspectorDebugMode";
    private static readonly string shortcutId = $"Main Menu/{menuPath}";
    private const KeyCode shortcutKey = KeyCode.F12;
    
    [InitializeOnLoadMethod]
    public static void AddShortCut()
    {
        ShortcutManager.instance.RebindShortcut(shortcutId,new ShortcutBinding(new KeyCombination(shortcutKey)));
    }
    
    [MenuItem(menuPath)]
    public static void ToggleInspectorDebugMode()
    {
        var inspectorWindowType = typeof(Editor).Assembly.GetType("UnityEditor.InspectorWindow");
        var inspectorWindow = EditorWindow.GetWindow(inspectorWindowType);
        var inspectorMode = inspectorWindowType.GetField("m_InspectorMode", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var mode = (int)inspectorMode.GetValue(inspectorWindow);
        var method = inspectorWindowType.GetMethod("SetMode",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        method.Invoke(inspectorWindow, new object[] {mode == 0 ? 1 : 0});
    }
}
#endif