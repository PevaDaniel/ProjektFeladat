using UnityEngine;

public class plusC : MonoBehaviour
{
    public float speed = 6.0f;
    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;

        // 1. MEGSZÜLETIK ÉS ELUGRIT EGY RANDOM MAGASSÁGBA
        float screenTop = mainCam.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        float screenBottom = mainCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;

        // 0.5f ráhagyás, hogy ne lógjon ki a képernyõ szélén
        float randomY = Random.Range(screenBottom + 0.5f, screenTop - 0.5f);

        // Beállítjuk az új pozíciót (X marad ahol a spawner tette, Y sorsolt)
        transform.position = new Vector3(transform.position.x, randomY, transform.position.z);
    }

    void Update()
    {
        // 2. FOLYAMATOSAN MOZOG BALRA
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // 3. ÖNMEGSEMMISÍTÉS (ha kiment a képbõl balra)
        float screenLeft = mainCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        if (transform.position.x < screenLeft - 2f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Ha eltalálja a játékost, eltûnik
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            // Itt adhatsz hozzá pontot vagy vehetsz le életet
        }
    }
}