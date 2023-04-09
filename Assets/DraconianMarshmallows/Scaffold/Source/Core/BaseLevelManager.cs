using System;

namespace DraconianMarshmallows.Scaffold.Core
{
  public abstract class BaseLevelManager : BaseSceneManager, LevelManagerInterface
  {
    public event Action OnLevelComplete;
  }
}
