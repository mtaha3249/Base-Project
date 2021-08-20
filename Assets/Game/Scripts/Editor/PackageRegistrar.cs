using UnityEditor;
using UnityEngine;

namespace Game.Scripts.Editor
{
    [InitializeOnLoad]
    public class PackageRegistrar : AssetPostprocessor
    {
        static PackageRegistrar()
        {
            AssetDatabase.importPackageStarted += OnImportPackageStarted;
            AssetDatabase.importPackageCompleted += OnImportPackageCompleted;
            AssetDatabase.importPackageFailed += OnImportPackageFailed;
            AssetDatabase.importPackageCancelled += OnImportPackageCancelled;
        }
    
        private static void OnImportPackageCancelled(string packageName)
        {
        }

        private static void OnImportPackageCompleted(string packagename)
        {
            Debug.Log($"Imported package: {packagename} Completed");
        }

        private static void OnImportPackageFailed(string packagename, string errormessage)
        {
        }

        private static void OnImportPackageStarted(string packagename)
        {
            Debug.Log($"Started importing package: {packagename}");
        }
    }
}
