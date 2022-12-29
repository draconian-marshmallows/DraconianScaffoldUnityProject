using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DraconianMarshmallows.Scaffold.Editor
{
  [InitializeOnLoad]
  public class SetMainSceneAsActiveOnPlay : MonoBehaviour
  {
    private static Scene lastActiveScene;

    static SetMainSceneAsActiveOnPlay()
    {
//      EditorApplication.update += onUpdate;

      Debug.Log("PAUSING!!");
      EditorApplication.isPaused = true;
      
      Debug.Log("SetMainSceneAsActiveOnPlay constructed...");

      lastActiveScene = EditorSceneManager.GetActiveScene();
      Debug.Log("Active scene: " + lastActiveScene.name);

      var scene = EditorSceneManager.GetSceneByBuildIndex(0);
      Debug.Log("Loading scene: " + scene.name);
      EditorSceneManager.SetActiveScene(scene);
      
      EditorApplication.playModeStateChanged += onPlayModeChanged;
    }

    private static void onPlayModeChanged(PlayModeStateChange change)
    {
      Debug.Log("Play state changed: " + change);

//      if (change.Equals(PlayModeStateChange.EnteredEditMode))
//      {
//        
//        EditorSceneManager.SetActiveScene(lastActiveScene);
//      }
    }

//    private static void onUpdate()
//    {
//      Debug.Log("SetMainSceneAsActiveOnPlay ran update...");
//      
//      // ReSharper disable once DelegateSubtraction
//      EditorApplication.update -= onUpdate;
//      
//      Debug.Log("Setting active scene back to what it was...");
//      EditorSceneManager.SetActiveScene(lastActiveScene);
//    }
  }
}
