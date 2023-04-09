using System;

namespace DraconianMarshmallows.Scaffold.Core
{
  public interface MainControllerInterface
  {
    event Action OnUpdate;
    event Action<LevelManagerInterface> OnStartLevel;

    void RegisterCurrentSceneManager(SceneManagerInterface manager);
    
    void RegisterLevelManager(LevelManagerInterface manager);
  }
}
