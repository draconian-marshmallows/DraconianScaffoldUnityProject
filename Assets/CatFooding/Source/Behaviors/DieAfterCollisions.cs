using UnityEngine;

namespace DraconianMarshmallows.CatFooding.Behaviors
{
  public class DieAfterCollisions : MonoBehaviour
  {
    private const int COLLISION_DAMAGE = 50;
    private const int PARTICLE_DAMAGE = 2;
    
    [SerializeField] private GameObject explosionPrefab;
    
    private int health = 80;
  
    // ReSharper disable once UnusedParameter.Local
    private void OnCollisionEnter2D(Collision2D collision) => onHit(COLLISION_DAMAGE);
    private void OnParticleCollision(GameObject other) => onHit(PARTICLE_DAMAGE);

    private void onHit(int damage)
    {
      if (--health < 0) 
        destroy();
    }

    private void destroy()
    {
      var trans = transform;
      Instantiate(explosionPrefab, trans.position, trans.rotation);
      Destroy(gameObject);
    }
  }
}
