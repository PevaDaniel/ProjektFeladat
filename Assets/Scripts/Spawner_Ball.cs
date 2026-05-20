using System.Collections;
using UnityEngine;

public class Spawner_Ball : MonoBehaviour
{
    public door1 sok;
    public GameObject greenBallPrefab;
    public GameObject redBallPrefab;
    public float greenBallChance = 60f;
    public float spawnRate = 0.7f;
    public float minX = 76.5f;
    public float maxX = 95.5f;
    private bool timerStarted = false;
    private bool isTimeUp = false;

    private float nextSpawnTime;

    void Update()
    {
        if (sok == null || sok.sok == false) return;
        if (isTimeUp) return;

        if (timerStarted == false)
        {
            timerStarted = true;
            StartCoroutine(StopSpawningAfterTime());
        }

        if (Time.time >= nextSpawnTime)
        {
            SpawnBall();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnBall()
    {
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        float randomRoll = Random.Range(0f, 100f);
        GameObject ballToSpawn;

        if (randomRoll <= greenBallChance)
        {
            ballToSpawn = greenBallPrefab;
        }
        else
        {
            ballToSpawn = redBallPrefab;
        }

        Instantiate(ballToSpawn, spawnPos, Quaternion.identity);
    }

    IEnumerator StopSpawningAfterTime()
    {
        yield return new WaitForSeconds(300f); // 10 másodperc teszteléshez

        // SZÓLUNK A SCOREMANAGERNEK, HOGY LETELT AZ IDŐ!
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.TimeIsUp();
        }
    }

    // === ITT VAN A FÜGGVÉNY, AMIT A SCOREMANAGER KERES ===
    public void StopSpawning()
    {
        isTimeUp = true;
    }
}