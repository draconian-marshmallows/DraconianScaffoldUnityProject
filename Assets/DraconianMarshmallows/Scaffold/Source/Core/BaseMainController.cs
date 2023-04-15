using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class BaseMainController : MonoBehaviorPlus, MainControllerInterface
  {
    public static BaseMainController Instance { get; private set; }
    
    [SerializeField] private LevelData levelData;

    public event Action OnUpdate;

    // TODO:: Do we want this for starting scenes that aren't levels ? 
    public event Action<LevelManagerInterface> OnStartLevel;
    
    private SceneLoader sceneLoader;
    private SceneManagerInterface currentSceneManager;
    private LevelManagerInterface currentLevelManager;

    // TODO:: Do we still need to come back to this ???
    // TODO:: Figure out how to expose this - this is just a POC for delegation of composed implementations. 
//    private readonly Action<int> loadLevel = sceneLoader.Load;
    
    protected override void Start()
    {
//      Debug.Log("MAIN controller started...");
      Instance = this;
      sceneLoader = new SceneLoader(this);
      sceneLoader.Load(levelData.initialLevelSceneIndex);
    }

    public void LoadLevel(int buildIndex) => sceneLoader.Load(buildIndex);

    #region Framework
    public void RegisterCurrentSceneManager(SceneManagerInterface manager) => 
      currentSceneManager = manager;

    public void RegisterLevelManager(LevelManagerInterface manager) => 
      currentLevelManager = manager;
    #endregion

    #region Unity Callbacks
    protected void Update()
    {
      OnUpdate?.Invoke();
    }
    #endregion
  }
}
