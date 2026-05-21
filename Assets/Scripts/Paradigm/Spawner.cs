using UnityEngine;

[System.Serializable]
public class PlatformType
{
    public GameObject prefab;
    [Range(0, 100)]
    public int spawnChance;
}

public class Spawner : MonoBehaviour
{
    public PlatformType[] platformTypes;

    public Transform lastPlatform;
    public float maxHeightDifference = 2f;
    public float minDistance = 4f;
    public float spawnOffsetX = 2f;

    public float spawnInterval = 0.5f;
    private float timer;

    public GameObject toStringPowerUp;
    public float powerUpChance = 20f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPlatform();
            timer = 0f;
        }
    }

    void SpawnPlatform()
    {
        GameObject prefab = GetRandomPlatform();

        Vector3 spawnPos = lastPlatform.position + new Vector3(minDistance, 0, 0);
        spawnPos.x += spawnOffsetX;
        spawnPos.y += Random.Range(-maxHeightDifference, maxHeightDifference);

        float heightDiff = spawnPos.y - lastPlatform.position.y;
        if (heightDiff > maxHeightDifference)
            spawnPos.y = lastPlatform.position.y + maxHeightDifference;
        if (heightDiff < -maxHeightDifference)
            spawnPos.y = lastPlatform.position.y - maxHeightDifference;

        float minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.15f, 0)).y;
        float maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.85f, 0)).y;
        spawnPos.y = Mathf.Clamp(spawnPos.y, minY, maxY);

        GameObject newPlatform = Instantiate(prefab, spawnPos, Quaternion.identity);
        newPlatform.AddComponent<SlideIn>();

        lastPlatform = newPlatform.transform;

        TrySpawnPowerUp(newPlatform.transform);
    }

    void TrySpawnPowerUp(Transform platform)
    {
        if (Random.Range(0f, 100f) <= powerUpChance)
        {
            Vector3 pos = platform.position + new Vector3(0, 1.5f, 0);
            Instantiate(toStringPowerUp, pos, Quaternion.identity);
        }
    }

    GameObject GetRandomPlatform()
    {
        int total = 0;
        foreach (var p in platformTypes)
            total += p.spawnChance;

        int roll = Random.Range(0, total);
        int current = 0;

        foreach (var p in platformTypes)
        {
            current += p.spawnChance;
            if (roll < current)
                return p.prefab;
        }

        return platformTypes[0].prefab;
    }
}
