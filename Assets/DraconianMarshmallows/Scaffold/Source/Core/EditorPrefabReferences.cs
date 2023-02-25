using UnityEngine;

namespace DraconianMarshmallows.Core
{
  [CreateAssetMenu(menuName = "DataAssets/EditorPrefabReferences")]
  public class EditorPrefabReferences : ScriptableObject
  {
    public static EditorPrefabReferences Instance;
    
    public GameObject TextPrefab;
    public GameObject ButtonPrefab;

    public static void Initialize(Object instance)
    {
      Instance = instance as EditorPrefabReferences;
      Debug.Log("Init:: " + Instance);
    }

//    private void Awake()
//    {
//      Debug.Log("EditorPrefabReferences :: Awake");
//      Instance = this;
//    }
//
//    private void OnEnable()
//    {
//      Debug.Log("EditorPrefabReferences :: OnEnable");
//      Instance = this;
//    }
//
//    private void OnValidate()
//    {
//      Debug.Log("EditorPrefabReferences :: OnEnable");
//      Instance = this;
//    }
  }
}
