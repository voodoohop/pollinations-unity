#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Pollinations.Unity.Samples
{
    /// <summary>
    /// Editor-only window that stores the development API key in EditorPrefs,
    /// which Unity never serializes into scenes, prefabs, or builds.
    /// Shipped games use the PollinationsAuth device flow instead.
    /// </summary>
    public sealed class PollinationsKeyWindow : EditorWindow
    {
        private string key;

        [MenuItem("Tools/Pollinations/Development API Key")]
        private static void Open()
        {
            var window = GetWindow<PollinationsKeyWindow>();
            window.titleContent = new GUIContent("Pollinations Key");
            window.key = EditorPrefs.GetString("PollinationsApiKey");
        }

        private void OnGUI()
        {
            EditorGUILayout.HelpBox(
                "Stored in EditorPrefs only - never serialized into scenes, prefabs, or builds. " +
                "Get a development key at enter.pollinations.ai/keys. For shipped games, " +
                "authorize each player with the PollinationsAuth device flow instead.",
                MessageType.Info);
            key = EditorGUILayout.PasswordField("Development key", key);
            using (new EditorGUI.DisabledScope(string.IsNullOrEmpty(key)))
            {
                if (GUILayout.Button("Save") && !string.IsNullOrEmpty(key))
                {
                    EditorPrefs.SetString("PollinationsApiKey", key);
                    Close();
                }
            }
        }
    }
}
#endif
