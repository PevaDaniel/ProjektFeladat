using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    private int score = 0;
    public int targetScore = 123;
    public Spawner_Ball spawner;
    public SpawnKey spawnKeyScript;

    private bool keySpawned = false;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Pontszám: " + score;

        if (score >= targetScore && keySpawned == false)
        {
            TriggerKeySpawnAndStop();
        }
    }

    public void TimeIsUp()
    {
        if (keySpawned == false)
        {
            TriggerKeySpawnAndStop();
            score = 0;
        }
    }

    void TriggerKeySpawnAndStop()
    {
        keySpawned = true;

        if (spawner != null)
        {
            spawner.StopSpawning();
            score = 0;
        }

        if (spawnKeyScript != null)
        {
            spawnKeyScript.CreateKey();
            score = 0;
        }
        
    }
}