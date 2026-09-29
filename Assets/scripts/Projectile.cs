using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    public StatusEffecf effecf;

    public float duration;

    private void Start()
    {
        transform.position = Vector3.zero;

        Destroy(gameObject, duration);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy == null) return; 

        enemy.ApplyStatus(effecf);
    }
}
