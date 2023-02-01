using UnityEngine;

// TODO:: Does this want to be DM.Scaffold.Core ? 
namespace DraconianMarshmallows.Core
{
  public class SceneLoader
  {
    public void Load(int buildIndex)
    {
      Debug.Log("Got request to load scene: " + buildIndex);
    }
  }
}
