using UnityEngine;

public class SpawnKey : MonoBehaviour
{
    public GameObject keyPrefab;
    public Vector2 spawnCoordinate = new Vector2(82f, -10f);
    public void CreateKey()
    {
        if (keyPrefab != null)
        {
            Instantiate(keyPrefab, spawnCoordinate, Quaternion.identity);
        }
    }
}