using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DraconianMarshmallows.Core
{
  public class BaseMainController : MonoBehaviorPlus
  {
    public static BaseMainController Instance { get; private set; }
    
    [SerializeField] private LevelData levelData;

    private Action onUpdate;
    private BaseLevelManager currentLevelManager;
    
    protected override void Start()
    {
      Debug.Log("MAIN controller started...");
      Instance = this;
      loadInitialLevelScene();
    }

    public void RegisterLevelController(BaseLevelManager manager)
    {
      currentLevelManager = manager;
      onUpdate += manager.OnUpdate;
    }

    // TODO:: Can we reference the BaseMainController.Instance to run all updates ?
    protected override void Update()
    {
      base.Update();
      onUpdate?.Invoke();
    }

    private void loadInitialLevelScene()
    {
      StartCoroutine(loadSceneAsynchronously(levelData.initialLevelSceneIndex));
    }

    private IEnumerator loadSceneAsynchronously(int buildIndex)
    {
      var operation = SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
      while ( ! operation.isDone)
      {
        Debug.Log("Loading progress: " + operation.progress);

        yield return null;
      }
    } 
  }
}
