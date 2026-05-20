using UnityEngine;
using TMPro; // Ez kell a TextMeshPro-hoz

public class ScoreManager : MonoBehaviour
{
    // Singleton minta, hogy más szkriptek könnyen elérjék
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Pontszám: " + score;
    }
}