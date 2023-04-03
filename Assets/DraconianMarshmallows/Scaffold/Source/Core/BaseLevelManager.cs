using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  public class BaseLevelManager : MonoBehaviorPlus
  {
    protected override void Start()
    {
      Debug.Log("Level controller started...");
      
      base.Start();
      // TODO:: Rename to scene manager ??
      BaseMainController.Instance.RegisterLevelManager(this);
    }

    protected internal override void OnUpdate()
    {
      Debug.Log("TODO:: Please implement me...");
//      throw new System.NotImplementedException();
    }
  }
}
