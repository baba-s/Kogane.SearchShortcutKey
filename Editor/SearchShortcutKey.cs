using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class SearchShortcutKey
    {
        [Shortcut( "Kogane/Open Search New Window", KeyCode.T, ShortcutModifiers.Action )]
        private static void OpenNewWindow()
        {
            EditorApplication.ExecuteMenuItem( "Window/Search/New Window" );
        }

        [Shortcut( "Kogane/Open Search Transient Window", KeyCode.T, ShortcutModifiers.Action | ShortcutModifiers.Shift )]
        private static void OpenTransientWindow()
        {
            EditorApplication.ExecuteMenuItem( "Window/Search/Transient Window" );
        }
    }
}