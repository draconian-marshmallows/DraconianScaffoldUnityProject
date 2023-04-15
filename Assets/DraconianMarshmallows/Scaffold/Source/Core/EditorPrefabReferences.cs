using UnityEngine;

namespace DraconianMarshmallows.Scaffold.Core
{
  [CreateAssetMenu(menuName = "DataAssets/EditorPrefabReferences")]
  public class EditorPrefabReferences : ScriptableObject
  {
    public static EditorPrefabReferences Instance;
    
    public GameObject TextPrefab;
    public GameObject ButtonPrefab;
    public GameObject TogglePrefab;
    public GameObject SliderPrefab;
    public GameObject ScrollBarPrefab;
    public GameObject ScrollViewPrefab;
    public GameObject InputFieldPrefab;
    public GameObject PanelPrefab;
    public GameObject DropDownPrefab;
  }
}
