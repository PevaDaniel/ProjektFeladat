using UnityEngine;

public class Ball : MonoBehaviour
{
    public int scoreValue; // Ezt az Inspectorban állítjuk be!

    void OnTriggerEnter2D(Collider2D other)
    {
        // Ha a játékoshoz ér
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(scoreValue);
            Destroy(gameObject); // Labda megsemmisítése
        }
        // Ha a talajhoz ér
        else if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}