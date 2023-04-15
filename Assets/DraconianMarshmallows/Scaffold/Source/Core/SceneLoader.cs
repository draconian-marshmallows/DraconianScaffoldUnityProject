using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class SceneLoader
  {
    // TODO:: Does this actually just want to be the base-type(MonoBehaviour) ?? 
    // TODO:: We could just pass a reference in. 
    private readonly MonoBehaviorPlus requester;

    private int lastLoadedBuildIndex = -1;

    public SceneLoader(MonoBehaviorPlus requester)
    {
      this.requester = requester;
    }

    public void Load(int sceneBuildIndex)
    {
//      Debug.Log("Got request to load scene: " + sceneBuildIndex);

      if (lastLoadedBuildIndex < 0)
      {
        requester.StartCoroutine(loadSceneAsynchronously(sceneBuildIndex));
        return;
      }
      requester.StartCoroutine(unloadSceneAsynchronously(lastLoadedBuildIndex, sceneBuildIndex));
//      requester.StartCoroutine(loadSceneAsynchronously(sceneBuildIndex));
    }

    private IEnumerator unloadSceneAsynchronously(int unloadBuildIndex, int loadBuildIndex = -1)
    {
      var operation = SceneManager.UnloadSceneAsync(unloadBuildIndex);
      while ( ! operation.isDone)
      {
        Debug.Log("Unloading progress: " + operation.progress);
        // TODO:: Expose progress for use in GUI, etc. 
        yield return null;
      }
      if (loadBuildIndex > -1)
        requester.StartCoroutine(loadSceneAsynchronously(loadBuildIndex));
    }
    
    private IEnumerator loadSceneAsynchronously(int buildIndex)
    {
      lastLoadedBuildIndex = buildIndex;
      
      var operation = SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
      while ( ! operation.isDone)
      {
//        Debug.Log("Loading progress: " + operation.progress);
        // TODO:: Expose progress for use in GUI, etc. 
        yield return null;
      }
    }
  }
}
