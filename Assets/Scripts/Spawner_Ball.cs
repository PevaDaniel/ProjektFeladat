using UnityEngine;

public class Spawner_Ball : MonoBehaviour
{
    [Header("Labda Prefabok")]
    public GameObject greenBallPrefab; // Ide húzd majd a zöld labdát
    public GameObject redBallPrefab;   // Ide húzd majd a piros labdát

    [Header("Esélyek (Százalékban)")]
    [Range(0, 100)]
    public float greenBallChance = 60f; // A zöld labda esélye (60%)

    [Header("Beállítások")]
    public float spawnRate = 1.5f;   // Milyen gyakran essen (másodperc)
    public float minX = 76.5f;
    public float maxX = 95.5f;

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnBall();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnBall()
    {
        // Véletlenszerű X pozíció kiszámolása
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        // Generálunk egy véletlen számot 0 és 100 között
        float randomRoll = Random.Range(0f, 100f);

        GameObject ballToSpawn;

        // Ha a szám 0 és 60 között van (ez pontosan 60% esély)
        if (randomRoll <= greenBallChance)
        {
            ballToSpawn = greenBallPrefab;
        }
        else // Ha 60 és 100 között van (ez a maradék 40% esély)
        {
            ballToSpawn = redBallPrefab;
        }

        // Labda létrehozása
        Instantiate(ballToSpawn, spawnPos, Quaternion.identity);
    }
}

 