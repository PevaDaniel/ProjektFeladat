using UnityEngine;

public class rubber : MonoBehaviour
{
    Rigidbody2D rb;
    public float maxFelfeleSebesseg = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * 55f;
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        // Itt már csak használjuk a korábban elmentett rb változót
        rb.linearVelocity = rb.linearVelocity.normalized * 55f;
    }

    void FixedUpdate()
    {
        // Csak a felfelé (Y tengely) irányuló sebességet vizsgáljuk
        if (rb.linearVelocity.y > maxFelfeleSebesseg)
        {
            // Ha gyorsabban megy felfelé, mint a limit, visszavágjuk a limitre.
            // Az X (vízszintes) sebességet békén hagyjuk.
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxFelfeleSebesseg);
        }
    }*/
}
