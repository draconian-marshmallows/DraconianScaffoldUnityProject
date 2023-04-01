using CatFooding;
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
      BaseMainController.Instance.LoadLevel(LevelIndices.LEVEL1);
    }
  }
}
