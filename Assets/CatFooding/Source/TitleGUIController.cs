using DraconianMarshmallows.Scaffold.Core;
using DraconianMarshmallows.Scaffold.GUI;
using UnityEngine;

namespace DraconianMarshmallows.CatFooding
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
      // TODO:: Does this want to upwardly delegate to main GUI controller ? 
      BaseMainController.Instance.LoadLevel(LevelIndices.LEVEL1);
    }
  }
}
