using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.GUI
{
  public class ButtonPlus : Button
  {
    [SerializeField] private TextMeshProUGUI label;

    public string Label
    {
      get => label.text;
      set => label.text = value;
    }
  }
}
