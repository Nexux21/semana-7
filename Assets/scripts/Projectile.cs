using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public StatusEffect effect;
    public float duration;

    private void Start()
    {
        
        Destroy(gameObject, duration);
    }

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy == null) return;

        enemy.ApplyStatus(effect, duration);
        Destroy(gameObject);
    }
}