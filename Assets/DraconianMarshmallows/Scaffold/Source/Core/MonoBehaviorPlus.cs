using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class MonoBehaviorPlus : MonoBehaviour
  {
    protected virtual void Start() { }

    // TODO:: This should be removed if we rig-up OnUpdate to be called. 
    protected virtual void Update() { }
    
    /// <summary>
    /// Internal callback to avoid Unity "Update" performance issue. 
    /// </summary>
    protected internal virtual void OnUpdate() { }
  }
}
