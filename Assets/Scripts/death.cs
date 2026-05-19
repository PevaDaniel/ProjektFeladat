using UnityEngine;

public class death : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 1. A Játékos (collision.gameObject) pozíciójának átállítása a 10, 10 pontra
            collision.gameObject.transform.position = new Vector3(-8f, -2.3f, 0f);

            // 2. Lekérjük a Játékos fizikai komponensét, és lenullázzuk a zuhanást/mozgást
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRb != null)
            {
                playerRb.linearVelocity = Vector2.zero;
                playerRb.angularVelocity = 0f;
            }
        }
    }
}
