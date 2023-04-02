using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
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

    public void RegisterLevelController(BaseLevelManager manager)
    {
      currentLevelManager = manager;
      onUpdate += manager.OnUpdate;
    }

    public void LoadLevel(int buildIndex) => 
      sceneLoader.Load(buildIndex);

    // TODO:: Can we reference the BaseMainController.Instance to run all updates ?
    // TODO:: ??
    protected override void Update()
    {
      base.Update();
      onUpdate?.Invoke();
    }
  }
}
