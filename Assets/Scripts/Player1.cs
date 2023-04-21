using UnityEngine;

public class Player1 : MonoBehaviour
{
    public GameObject bulletPrefeb;
    public Transform shootingPoint;
    private bool fired = false;

    void Update()
    {
        // firing bullet
        if (FindObjectOfType<GameManager>().isStart && !fired && Input.GetKey(KeyCode.A)) {
            Instantiate(bulletPrefeb, shootingPoint.position, transform.rotation);
            fired = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Bullet") {
            Hit();
        }
    }

    public void Hit()
    {
        FindObjectOfType<GameManager>().EndGame("Player 1");
    }
}
