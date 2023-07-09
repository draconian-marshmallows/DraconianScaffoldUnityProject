using static UnityEditor.EditorUtility;
using static UnityEditor.AssetDatabase;

namespace DraconianMarshmallows.Scaffold.Editor
{
    internal static class ProjectManager
    {
        internal static void CreateProject()
        {
            const string ASSETS = "Assets";
            var ASSETS_SLASH = $"{ASSETS}/";
            var path = SaveFilePanelInProject(
                "Project Name", "MyFirstScaffoldProject", 
                null, "Please enter a project name:");

            if (string.IsNullOrEmpty(path) || ! path.StartsWith(ASSETS_SLASH)) return;
            path = path.Replace(ASSETS_SLASH, "");
            
            // Create root project directory: 
            CreateFolder(ASSETS, path);
            
            // Create standard sub-directories: 
            CreateFolder($"{ASSETS_SLASH}{path}", "Data");
            CreateFolder($"{ASSETS_SLASH}{path}", "Scenes");
            CreateFolder($"{ASSETS_SLASH}{path}", "Source");
        }
    }
}
