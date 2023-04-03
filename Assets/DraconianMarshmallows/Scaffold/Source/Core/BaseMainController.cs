using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  // TODO:: Use MonoBehaviorPlus as the interface for stuff to be delegated from major controller/managers. 
  public class BaseMainController : MonoBehaviorPlus
  {
    public static BaseMainController Instance { get; private set; }
    
    [SerializeField] private LevelData levelData;

    private Action onUpdate;
    private SceneLoader sceneLoader;
    private BaseLevelManager currentLevelManager;

    // TODO:: Figure out how to expose this - this is just a POC for delegation of composed implementations. 
//    private readonly Action<int> loadLevel = sceneLoader.Load;
    
    protected override void Start()
    {
      Debug.Log("MAIN controller started...");
      Instance = this;
      
      sceneLoader = new SceneLoader(this);
      sceneLoader.Load(levelData.initialLevelSceneIndex);
    }

    public void RegisterLevelManager(BaseLevelManager manager)
    {
      currentLevelManager = manager;
      onUpdate += manager.OnUpdate;
    }

    public void LoadLevel(int buildIndex)
    {
      if (currentLevelManager) 
        onUpdate -= currentLevelManager.OnUpdate;
      
      sceneLoader.Load(buildIndex);
    }

    // TODO:: Should be restricted to main controllers ?? 
    public void AddOnUpdateListener(Action callback)
    {
      onUpdate += callback;
    }

    protected void Update()
    {
      onUpdate?.Invoke();
    }
  }
}
