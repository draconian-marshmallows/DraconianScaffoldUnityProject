using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class BaseSceneManager : MonoBehaviorPlus, SceneManagerInterface
  {
    public event Action OnSceneComplete;

    protected override void Start()
    {
      Debug.Log("Scene controller started...");
      
      base.Start();
      BaseMainController.Instance.RegisterCurrentSceneManager(this);
    }
  }
}
