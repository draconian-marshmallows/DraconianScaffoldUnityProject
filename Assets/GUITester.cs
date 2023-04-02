using DraconianMarshmallows.Scaffold.GUI;
using UnityEngine;

public class GUITester : MonoBehaviour
{
    [SerializeField] private ButtonPlus testButton;

    private void Start()
    {
//        testButton.onClick.AddListener(onClick);
    }

    private static void onClick()
    {
        Debug.Log("Button clicked !");
    }
}
