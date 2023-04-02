using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  [CreateAssetMenu(menuName = "DataAssets/LevelData", fileName = "LevelData")]
  
  public class LevelData : ScriptableObject
  {
    public int initialLevelSceneIndex;
  }
}
