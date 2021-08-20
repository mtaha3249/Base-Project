using UnityEngine;

namespace Game.Scripts.Editor
{
    public class BaseProjectEditor
    {
        public static string version = "V1.0.5b2";

        public static string bodyText =
            "Base Project Framework contains basic project structure which is required by the developer, designer and artist to follow.";

        public static string changeLog = "Read Changelog for what's new.";

        public static string basePackagePath = "Assets/Game/External Packages/";
        public static string developerPackage = "Developer Package.unitypackage";
        public static string artPackage = "Art Package.unitypackage";
        public static string naughtyAttribute = "NaughtyAttribute v2.0.7.unitypackage";
        public static string hierarchy = "Hierarchy 2 v1.2.1.unitypackage";
        public static string SOArchitecture = "ScriptableObject - Architecture v1.7.0.unitypackage";
        public static string screenShootMaker = "ScreenshotTool-v1.unitypackage";

        public static void DrawLogo()
        {
            GUILayout.Space(10);
            Texture texture = Resources.Load("Logo") as Texture;
            GUIStyle logo = new GUIStyle();
            logo.fontSize = 10;
            logo.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label(texture, logo);
        }

        public static void DrawTitle(string Title)
        {
            GUIStyle title = new GUIStyle();
            title.fontSize = 15;
            title.alignment = TextAnchor.MiddleCenter;
            title.normal.textColor = Color.white;
            title.fontStyle = FontStyle.Bold;
            title.wordWrap = true;
            GUILayout.Space(5);
            GUILayout.Label(Title, title);
        }

        public static void DrawVersion()
        {
            GUIStyle version = new GUIStyle();
            version.fontSize = 10;
            version.alignment = TextAnchor.MiddleCenter;
            version.normal.textColor = Color.gray;
            version.wordWrap = true;
            GUILayout.Label("Version: " + BaseProjectEditor.version, version);
        }
    }
}