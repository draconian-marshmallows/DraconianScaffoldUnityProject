using DraconianMarshmallows.Scaffold.Core;
using UnityEngine;

namespace CatFooding.Source
{
  public class ShipMotionController : MonoBehaviorPlus2D
  {
    private const float HORIZONTAL_VELOCITY = .05f;

    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform bombSpawnPoint;

    private float horizontalVelocity = HORIZONTAL_VELOCITY;
    private Vector3 positionHolder;
    private Transform trans;

    protected override void Start()
    {
      base.Start();
      trans = transform;
      registerForUpdateCallbacks();
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
      Debug.Log("Collided ...");
      
//      if (collision.gameObject.layer)
//      {
//        
//      }
      horizontalVelocity = -horizontalVelocity;
    }

    protected override void onUpdate()
    {
      positionHolder = trans.position;
      positionHolder.x += horizontalVelocity;
      trans.position = positionHolder;

      if (Input.GetKeyDown(KeyCode.Space)) 
        dropBomb();
    }

    private void dropBomb() => Instantiate(bombPrefab, bombSpawnPoint.position, bombSpawnPoint.rotation);
  }
}
