using UnityEngine;

namespace DraconianMarshmallows.Core
{
//  [DefaultExecutionOrder(404)]
  public class BaseLevelManager : MonoBehaviorPlus
  {
    protected override void Start()
    {
      Debug.Log("Level controller started...");
      
      base.Start();
      BaseMainController.Instance.RegisterLevelController(this);
    }

    protected internal override void OnUpdate()
    {
      Debug.Log("TODO:: Please implement me...");
      throw new System.NotImplementedException();
    }
  }
}
