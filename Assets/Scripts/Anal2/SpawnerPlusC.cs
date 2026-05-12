using UnityEngine;

public class SpawnerPlusC : MonoBehaviour
{
    [Header("Beállítások")]
    public GameObject plusCPrefab; // Ide húzd be a kék Prefabodat a Project ablakból
    public float spawnRate = 2.0f; // Hány másodpercenként szülessen új tárgy

    private float nextSpawn = 0.0f;

    void Update()
    {
        // Megnézzük, eltelt-e már elég idõ az elõzõ spawn óta
        if (Time.time > nextSpawn)
        {
            // Beállítjuk a következõ spawn idõpontját
            nextSpawn = Time.time + spawnRate;

            // Létrehozzuk a másolatot a Spawner pozíciójában
            // Mivel a Spawner a kamera gyereke, ez mindig a képernyõ szélén lesz
            Instantiate(plusCPrefab, transform.position, Quaternion.identity);
        }
    }
}