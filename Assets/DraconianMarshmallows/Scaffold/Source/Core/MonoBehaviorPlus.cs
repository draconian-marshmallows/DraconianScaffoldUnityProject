using System;
using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public abstract class MonoBehaviorPlus : MonoBehaviour
  {
    protected void registerForUpdateCallbacks() => 
      BaseMainController.Instance.OnUpdate += (Action) onUpdate;

    // ReSharper disable once MemberCanBePrivate.Global exposed to subclasses. 
    protected void unregisterForUpdateCallbacks() => 
      BaseMainController.Instance.OnUpdate -= onUpdate;

    /// <summary>
    /// Called by Unity Update method if you run `registerForUpdates`. 
    /// Internal callback to avoid Unity "Update" performance issues. 
    /// </summary>
    protected virtual void onUpdate() {}
    
    #region Unity Callbacks
    // ReSharper disable once Unity.RedundantEventFunction allows easier reuse with inheritance. 
    protected virtual void Awake() {}
    protected virtual void Start() {}
    protected virtual void OnDestroy() => unregisterForUpdateCallbacks();
    #endregion
  }
}
