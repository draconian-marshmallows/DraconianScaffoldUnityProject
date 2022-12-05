using System;
using UnityEngine;

namespace DraconianMarshmallows.Core
{
  [DefaultExecutionOrder(-404)]
  public class BaseMainController : MonoBehaviorPlus
  {
    public static BaseMainController Instance { get; private set; }

    private Action onUpdate;
    private BaseLevelManager currentLevelManager;

    // TODO:: Can we make sure this runs before anything in the level in the editor ???
    protected override void Start()
    {
      Debug.Log("MAIN controller started...");
      Instance = this;
    }

    public void RegisterLevelController(BaseLevelManager manager)
    {
      currentLevelManager = manager;
      onUpdate += manager.OnUpdate;
    }

    protected override void Update()
    {
      base.Update();
      onUpdate();
    }

// TODO:: Can we reference the BaseMainController.Instance to run all updates ?
  }
}
