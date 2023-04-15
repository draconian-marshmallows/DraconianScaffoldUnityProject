using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  /// <summary>
  /// MonoBehaviorPlus with overrideable 2D Unity callback for use with Scaffold. 
  /// </summary>
  public class MonoBehaviorPlus2D : MonoBehaviorPlus
  {
    protected virtual void OnTriggerEnter2D(Collider2D collider) { }
  }
}
