using DraconianMarshmallows.Core;
using DraconianMarshmallows.GUI;
using UnityEngine;

namespace Source
{
  public class TitleGUIController : MonoBehaviorPlus
  {
    [SerializeField] private ButtonPlus startButton;

    protected override void Start()
    {
      base.Start();
      startButton.onClick.AddListener(onClickStart);
    }

    private static void onClickStart()
    {
      // TODO:: Add place for level build indices. 
      MainController.Instance.LoadLevel(2);
    }
  }
}
