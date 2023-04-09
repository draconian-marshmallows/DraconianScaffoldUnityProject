using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class MonoBehaviorPlus : MonoBehaviour
  {
    protected void registerForUpdateCallbacks()
    {
      BaseMainController.Instance.OnUpdate += (Action) onUpdate;
    }

    /// <summary>
    /// Called by Unity Update method if you run `registerForUpdates`. 
    /// Internal callback to avoid Unity "Update" performance issues. 
    /// </summary>
    private void onUpdate() { }
    
    #region Unity Callbacks
    protected virtual void Awake() {}

    protected virtual void Start() {}

    protected virtual void OnDestroy()
    {
      BaseMainController.Instance.OnUpdate -= onUpdate;
    }
    #endregion
  }
}
