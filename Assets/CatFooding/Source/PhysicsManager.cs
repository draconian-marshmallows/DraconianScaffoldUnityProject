using UnityEngine;

namespace DraconianMarshmallows.CatFooding
{
  public class PhysicsManager
  {
    public static void Initialize()
    {
      Physics.IgnoreLayerCollision((int) Layer.TERRAIN, (int) Layer.BUILDINGS);
    }
    
    public enum Layer
    {
      DEFAULT, FX, IGNORE_RAY, 
      PLAYERS,
      WATER, UI,
      TERRAIN,
      BUILDINGS,
    }
  }
}
