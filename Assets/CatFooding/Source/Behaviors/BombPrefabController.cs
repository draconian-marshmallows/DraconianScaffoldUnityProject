using UnityEngine;

public class BombPrefabController : MonoBehaviour
{
    [SerializeField] private Renderer spriteRenderer;
    [SerializeField] private Collider2D circleCollider;
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private GameObject explosionParticleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(spriteRenderer);
        Destroy(circleCollider);
        Destroy(body);
        explosionParticleSystem.SetActive(true);
        Destroy(gameObject, 3f);
    }
}
