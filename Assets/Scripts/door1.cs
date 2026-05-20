using System.Collections;
using UnityEngine;

public class door1 : MonoBehaviour
{
    public bool hasKey = false;
    public bool sok = false;
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
            if (hasKey == true)
            {
                collision.gameObject.transform.position = new Vector3(85.95f, -13.3f, 0f);
                Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (playerRb != null)
                {
                    playerRb.linearVelocity = Vector2.zero;
                    playerRb.angularVelocity = 0f;
                }
                hasKey = false;
                StartCoroutine(Szenvedes());
            }
        }
    }

    IEnumerator Szenvedes()
    {
        yield return new WaitForSeconds(10);
        sok = true;

    }
}
