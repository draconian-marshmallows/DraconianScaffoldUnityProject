using DraconianMarshmallows.Scaffold.Core;

namespace DraconianMarshmallows.Scaffold.GUI
{
  public class BaseMainGUIController : MonoBehaviorPlus
  {
    public BaseMainController MainController { private get; set; }

    // TODO:: Switch this to plug into Level-Manager. 
    public void OnStartLevel(int buildIndex)
    {
//      MainController.OnStartLevel(buildIndex);
    }
  }
}
