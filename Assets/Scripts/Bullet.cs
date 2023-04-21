using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeTime = 5f;
    public new Rigidbody2D rigidbody { get; private set; }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    private void FixedUpdate()
    {
        // move Bullet
        rigidbody.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // Destroy when collision with Player
        if (collision.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
