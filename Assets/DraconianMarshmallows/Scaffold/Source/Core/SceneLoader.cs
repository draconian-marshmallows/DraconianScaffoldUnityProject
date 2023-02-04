using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// TODO:: Does this want to be DM.Scaffold.Core ? 
namespace DraconianMarshmallows.Core
{
  public class SceneLoader
  {
    private readonly MonoBehaviorPlus requester;

    public SceneLoader(MonoBehaviorPlus requester)
    {
      this.requester = requester;
    }

    public void Load(int sceneBuildIndex)
    {
      Debug.Log("Got request to load scene: " + sceneBuildIndex);
      
      requester.StartCoroutine(loadSceneAsynchronously(sceneBuildIndex));
    }
    
    private IEnumerator loadSceneAsynchronously(int buildIndex)
    {
      var operation = SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
      while ( ! operation.isDone)
      {
        Debug.Log("Loading progress: " + operation.progress);

        yield return null;
      }
    }
  }
}
