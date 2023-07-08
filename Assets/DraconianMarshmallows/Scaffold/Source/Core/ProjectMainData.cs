using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  [CreateAssetMenu(menuName = "DataAssets/ProjectMainData", fileName = "ProjectMainData")]
  
  public class ProjectMainData : ScriptableObject
  {
    // TODO:: Rename to initialLevelSceneBuildIndex ?
    public int initialLevelSceneIndex;
  }
}
