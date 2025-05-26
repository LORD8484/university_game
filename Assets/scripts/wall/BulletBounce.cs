using UnityEngine;

public class BulletBounceTrigger : MonoBehaviour
{
    public float bounceSpeed = 5f;
    public float bounceAngle = 15f;  

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Vector2 backward = -rb.velocity.normalized;

            float angleRad = bounceAngle * Mathf.Deg2Rad;

             
            Vector2 bounceDirection = new Vector2(
                backward.x * Mathf.Cos(angleRad) + backward.y * Mathf.Sin(angleRad),
                -backward.x * Mathf.Sin(angleRad) + backward.y * Mathf.Cos(angleRad)
            );

            rb.velocity = bounceDirection.normalized * bounceSpeed;
        }
    }
}
