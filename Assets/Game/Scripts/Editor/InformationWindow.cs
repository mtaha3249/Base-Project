using UnityEditor;
using UnityEngine;

namespace Game.Scripts.Editor
{
    public class InformationWindow : EditorWindow
    {
        private GUIStyle packagetitle;
        Vector2 scrollPosition = Vector2.zero;

        [MenuItem("Base Project/About")]
        public static void ShowWindow()
        {
            GetWindow<InformationWindow>("About");
            GetWindow<InformationWindow>().minSize = new Vector2(512, 200);
            GetWindow<InformationWindow>().maxSize = new Vector2(512, 500);
        }

        private void OnGUI()
        {
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true,
                GUILayout.Width(GetWindow<InformationWindow>().position.width),
                GUILayout.Height(GetWindow<InformationWindow>().position.height));
            GUILayout.BeginVertical();
            BaseProjectEditor.DrawLogo();
            BaseProjectEditor.DrawTitle("Base Project Framework");
            BaseProjectEditor.DrawVersion();

            GUIStyle body = new GUIStyle();
            body.fontSize = 12;
            body.wordWrap = true;
            body.alignment = TextAnchor.MiddleCenter;
            body.normal.textColor = Color.white;

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            GUILayout.Label("" + BaseProjectEditor.bodyText, body);
            GUILayout.Space(10);
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            GUILayout.Label("" + BaseProjectEditor.changeLog, body);
            GUILayout.Space(10);
            GUILayout.EndHorizontal();

            GUILayout.Space(5);
            packagetitle = new GUIStyle();
            packagetitle.font = Resources.Load("font") as Font;
            packagetitle.fontSize = 15;
            packagetitle.alignment = TextAnchor.MiddleCenter;
            packagetitle.normal.textColor = Color.white;
            packagetitle.fontStyle = FontStyle.Normal;
            packagetitle.wordWrap = true;
            Packages();

            GUILayout.EndVertical();
            GUILayout.EndScrollView();
        }

        static void HorizontalLine(Color color)
        {
            GUIStyle horizontalLine;
            horizontalLine = new GUIStyle();
            horizontalLine.normal.background = EditorGUIUtility.whiteTexture;
            horizontalLine.margin = new RectOffset(0, 0, 4, 4);
            horizontalLine.fixedHeight = 1;

            var c = GUI.color;
            GUI.color = color;
            GUILayout.Box(GUIContent.none, horizontalLine);
            GUI.color = c;
        }

        void Packages()
        {
            BasePackage();
            DefaultPackages();
            EditorSDK();
            ProjectOptimizer();
            SDK();
            PostPackage();

            GUILayout.Space(20);
        }

        void BasePackage()
        {
            DrawTitle("BASE PACKAGES");

            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            if (GUILayout.Button("Import Developer Package"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.developerPackage,
                    true);
            }

            if (GUILayout.Button("Import Artist Package"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.artPackage, true);
            }

            GUILayout.Space(10);
            GUILayout.EndHorizontal();
        }

        void DefaultPackages()
        {
            DrawTitle("DEFAULT PACKAGES");

            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            if (GUILayout.Button("Import SO Architecture"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.SOArchitecture,
                    true);
            }

            GUILayout.Space(10);
            GUILayout.EndHorizontal();
        }

        void ProjectOptimizer()
        {
            // DrawTitle("PROJECT OPTIMIZER PACKAGES");
        }

        void EditorSDK()
        {
            DrawTitle("EDITOR PACKAGES");

            GUILayout.BeginHorizontal();
            GUILayout.Space(10);

            if (GUILayout.Button("Import Hierarchy 2"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.hierarchy, true);
            }

            if (GUILayout.Button("Import Naughty Attributes"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.naughtyAttribute,
                    true);
            }

            GUILayout.Space(10);
            GUILayout.EndHorizontal();
        }

        void SDK()
        {
            // DrawTitle("SDK PACKAGES");
        }
        
        void PostPackage()
        {
            DrawTitle("POST PRODUCTION PACKAGES");

            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            if (GUILayout.Button("Import Screenshot Package"))
            {
                AssetDatabase.ImportPackage(BaseProjectEditor.basePackagePath + BaseProjectEditor.screenShootMaker,
                    true);
            }

            GUILayout.Space(10);
            GUILayout.EndHorizontal();
        }

        void DrawTitle(string title)
        {
            GUILayout.Space(5);
            HorizontalLine(Color.gray);
            GUILayout.Label(title, packagetitle);
        }
    }
}