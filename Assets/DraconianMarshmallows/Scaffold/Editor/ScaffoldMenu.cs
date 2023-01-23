using DraconianMarshmallows.Core;
using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Editor
{
  public static class ScaffoldMenu
  {
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
  }
}
