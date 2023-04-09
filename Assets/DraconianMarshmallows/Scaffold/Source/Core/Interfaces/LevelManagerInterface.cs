using System;

namespace DraconianMarshmallows.Scaffold.Core
{
  public interface LevelManagerInterface : SceneManagerInterface
  {
    event Action OnLevelComplete;
  }
}
