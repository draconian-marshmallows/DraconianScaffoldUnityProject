using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class MonoBehaviorPlus : MonoBehaviour
  {
    protected virtual void Start()
    {
      BaseMainController.Instance.AddOnUpdateListener(OnUpdate);
    }
    
    /// <summary>
    /// Internal callback to avoid Unity "Update" performance issue. 
    /// </summary>
    protected internal virtual void OnUpdate() { }
  }
}
