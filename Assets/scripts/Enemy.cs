using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 5.0f;
    public float Speed = 2.0f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);
            if (distanceToPlayer <= detectionRadius)
            {
                Vector2 direction = (player.position - transform.position).normalized;
                movement = direction;
            }
            else
            {
                movement = Vector2.zero;
            }
        }
    }

    private void FixedUpdate()
    {
        if (rb != null)
        {
            rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
        }
    }

    public void ApplyStatus(StatusEffect effect)
    {
        Debug.Log("Enemigo recibe: " + effect);
    }

    public void ApplyStatus(StatusEffect effect, float duration)
    {
        Debug.Log("Enemigo recibe: " + effect + " | Tiempo: " + duration);
    }
}