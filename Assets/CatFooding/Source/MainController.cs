using DraconianMarshmallows.CatFooding;
using DraconianMarshmallows.Scaffold.Core;

namespace Source
{
  public class MainController : BaseMainController
  {
    protected override void Start()
    {
      PhysicsManager.Initialize();
      base.Start();
    }
  }
}
