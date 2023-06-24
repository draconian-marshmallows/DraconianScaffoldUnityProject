using System;
using UnityEngine;

namespace DraconianMarshmallows.CatFooding.Behaviors
{
  public class DieAfterCollisions : MonoBehaviour
  {
    // ReSharper disable once UnusedParameter.Local
    private void OnCollisionEnter2D(Collision2D collision)
    {
      Debug.Log($"{gameObject.name}: building collided!!");
    }

    private void OnParticleCollision(GameObject other)
    {
      Debug.Log($"{gameObject.name}: particle collided!!");
    }
    
    
  }
}
