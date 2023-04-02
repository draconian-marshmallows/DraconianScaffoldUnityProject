using DraconianMarshmallows.Scaffold.GUI;
using UnityEngine;

namespace Source
{
  public class MainGUIController : BaseMainGUIController
  {
    [SerializeField] private ButtonPlus testButton;

    protected override void Start()
    {
      base.Start();
      testButton.Label = "Hello Button";
    }
  }
}
