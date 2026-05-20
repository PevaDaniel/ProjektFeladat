using UnityEngine;

public class door2 : MonoBehaviour
{
    public bool hasKey2 = false;
    private Rigidbody2D rb;
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
            if (hasKey2 == true)
            {
                collision.gameObject.transform.position = new Vector3(85.95f, -13.3f, 0f);
                Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (playerRb != null)
                {
                    playerRb.linearVelocity = Vector2.zero;
                    playerRb.angularVelocity = 0f;
                }
            }
        }
    }
}