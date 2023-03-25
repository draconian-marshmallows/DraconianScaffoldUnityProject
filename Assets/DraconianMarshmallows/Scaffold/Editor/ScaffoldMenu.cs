using DraconianMarshmallows.Core;
using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Editor
{
  public static class ScaffoldMenu
  {
    private const string GUI_CREATE_MENU_PATH = "GameObject/UI/";
    private const string PREFAB_REFERENCE_PATH = "Assets/DraconianMarshmallows/DataAssets/EditorPrefabReferences.asset";
    
//    [MenuItem("Assets/Create/DMG/My Stuff")]
//    public static void DoSomething()
//    {
//      Debug.Log("Thing created... ");
//    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Text")][UsedImplicitly]
    public static void AddText()
    {
      initializePrefabReferences();
      Debug.Log($"instantiatePrefab({EditorPrefabReferences.Instance})");
      instantiatePrefab(EditorPrefabReferences.Instance.TextPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Button")][UsedImplicitly]
    public static void AddButton()
    {
      initializePrefabReferences();
      Debug.Log("instantiatePrefab(EditorPrefabReferences.Instance.ButtonPrefab)");
      instantiatePrefab(EditorPrefabReferences.Instance.ButtonPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Toggle")][UsedImplicitly]
    public static void AddToggle()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.TogglePrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Slider")][UsedImplicitly]
    public static void AddSlider()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.SliderPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Scroll Bar")][UsedImplicitly]
    public static void AddScrollBar()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.ScrollBarPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Scroll View")][UsedImplicitly]
    public static void AddScrollView()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.ScrollViewPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Input Field")][UsedImplicitly]
    public static void AddInputField()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.InputFieldPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Panel")][UsedImplicitly]
    public static void AddPanel()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.PanelPrefab);
    }
    
    [MenuItem(GUI_CREATE_MENU_PATH + "DGUI Drop Down")][UsedImplicitly]
    public static void AddDropDown()
    {
      initializePrefabReferences();
      instantiatePrefab(EditorPrefabReferences.Instance.DropDownPrefab);
    }

//    [MenuItem("Draconian Marshmallows/Test 1")]
//    public static void Test1()
//    {
////      Selection.activeObject = AssetDatabase.LoadMainAssetAtPath("Assets/Prefabs/");
//      
////      Selection.activeObject = AssetDatabase.LoadMainAssetAtPath
////        ("Assets/DraconianMarshmallows/DataAssets/EditorPrefabReferences.asset");
//
//      initializePrefabReferences();
//
//      Debug.Log("Test !!!! : " + EditorPrefabReferences.Instance.ButtonPrefab);
//    }

    [MenuItem("Draconian Marshmallows/Set Current Scenes as Test Level")][UsedImplicitly]
    public static void SetCurrentScenesAsTestLevelScenes()
    {
      var assetIds = AssetDatabase.FindAssets("LevelData t:LevelData", new []{"Assets/Data"});
      var dataPath = AssetDatabase.GUIDToAssetPath(assetIds[0]);
      var data = AssetDatabase.LoadAssetAtPath<LevelData>(dataPath);
      Debug.Log("Initial level index: " + data.initialLevelSceneIndex);

      var sceneCount = EditorSceneManager.sceneCount;
      Debug.Log("Scenes loaded: " + sceneCount);
      if (sceneCount < 2)
      {
        Debug.LogError("Please add your main(persistent) & first level scenes to the hierarchy " +
                       "with the first scene being your main scene.");
        return;
      }

      data.initialLevelSceneIndex = EditorSceneManager.GetSceneAt(1).buildIndex;
      AssetDatabase.ForceReserializeAssets(new []{dataPath});
//      AssetDatabase.ImportAsset(dataPath);
      Debug.Log("Initial level index updated to: " + data.initialLevelSceneIndex);

      EditorSceneManager.playModeStartScene 
        = AssetDatabase.LoadAssetAtPath<SceneAsset>(EditorSceneManager.GetSceneAt(0).path);
    }

    private static void instantiatePrefab(Object prefab)
    {
//      Debug.Log("instantiatePrefab !!!!!!!!!");
      
      if ( ! initializePrefabReferences())
        return;

//      Debug.Log("instantiatePrefab @@@@@@@@@");
      var instance = PrefabUtility.InstantiatePrefab(prefab, Selection.activeTransform);
      Undo.RegisterCreatedObjectUndo(instance, $"Create {instance.name}");
      Selection.activeObject = instance;
    }

    /// <returns>True if initialization was successful.</returns>
    private static bool initializePrefabReferences()
    {
//      Debug.Log("initializePrefabReferences !!!!!!!!!!!!");
      var scriptableObject = AssetDatabase.LoadMainAssetAtPath(PREFAB_REFERENCE_PATH);
      if (null == scriptableObject)
      {
        Debug.LogError(
          $"Could not get prefab references. Has the asset file at \"{PREFAB_REFERENCE_PATH}\" been moved or deleted ?");
        
        return false;
      }
//      Debug.Log("initializePrefabReferences @@@@@@@@@@@@");
      EditorPrefabReferences.Instance = (EditorPrefabReferences) scriptableObject;
//      EditorPrefabReferences.Initialize((EditorPrefabReferences) scriptableObject);
//      Debug.Log("Initialized EditorPrefabReferences instance.");
      return true;
    }
  }
}
