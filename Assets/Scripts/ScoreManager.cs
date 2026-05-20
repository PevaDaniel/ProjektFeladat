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

        // Ha elértük a pontot játék közben, és a kulcs még nem jelent meg
        if (score >= targetScore && keySpawned == false)
        {
            TriggerKeySpawnAndStop();
        }
    }

    // Ezt a függvényt hívja meg a Spawner, ha letelik az 5 perc!
    public void TimeIsUp()
    {
        // Csak akkor fut le, ha a pontszámmal MÉG NEM nyertünk előtte
        if (keySpawned == false)
        {
            TriggerKeySpawnAndStop();
        }
    }

    // Közös függvény a leállításhoz és kulcsdobáshoz, hogy ne kelljen kétszer leírni
    void TriggerKeySpawnAndStop()
    {
        keySpawned = true;

        // 1. LEÁLLÍTJUK A LABDAESŐT
        if (spawner != null)
        {
            spawner.StopSpawning();
        }

        // 2. SZÓLUNK A SPAWNKEY-NEK, HOGY GENERÁLJA LE A KULCSOT
        if (spawnKeyScript != null)
        {
            spawnKeyScript.CreateKey();
        }
        
    }
}