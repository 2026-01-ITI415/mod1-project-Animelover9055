using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject bombPrefab;

    public float spawnWidth = 8f;
    public float spawnHeight = 8f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", 1f, 1.5f);
        InvokeRepeating("SpawnBomb", 2f, 2f);
    }

    void SpawnCoin()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }

    void SpawnBomb()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0);
        Instantiate(bombPrefab, spawnPos, Quaternion.identity);
    }
}