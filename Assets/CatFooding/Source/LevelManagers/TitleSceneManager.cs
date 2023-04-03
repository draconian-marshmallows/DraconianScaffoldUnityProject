using DraconianMarshmallows.Scaffold.Core;
using UnityEngine;

namespace Source.LevelManagers
{
  public class TitleSceneManager : BaseLevelManager
  {
    protected internal override void OnUpdate()
    {
      base.OnUpdate();
      Debug.Log("Title manager updated...");
    }
  }
}
