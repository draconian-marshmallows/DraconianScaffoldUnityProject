using DraconianMarshmallows.Scaffold.Core;
using UnityEngine;

namespace CatFooding.Source
{
  public class ShipMotionController : MonoBehaviorPlus
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
      BaseMainController.Instance.OnUpdate += onUpdate;
    }

    // TODO:: Add this to MB Plus ? 
    private void OnTriggerEnter2D(Collider2D collision)
    {
      horizontalVelocity = -horizontalVelocity;
    }

    private void onUpdate()
    {
      positionHolder = trans.position;
      positionHolder.x += horizontalVelocity;
      trans.position = positionHolder;
    }
  }
}
